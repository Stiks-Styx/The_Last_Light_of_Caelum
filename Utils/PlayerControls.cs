using StyxEngine.Components;
using StyxEngine.Utils;
using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace StyxEngine.Engine
{
    public class PlayerControls : Form
    {
        private MainGame _mainGame;
        private AnimationController animation;
        private HealthBar _healthBar;

        private PictureBox rightAttackHitBox;
        private PictureBox leftAttackHitBox;

        private bool lastFacingRight = true;
        private bool isAttacking = false;
        private float attackTimer = 0f;
        private const float attackDuration = .25f;

        private bool isCrouching = false;
        private bool wasCrouching = false;
        private float crouchBufferTimer = 0f;

        private bool isDashing = false;
        private float dashTimer = 0f;
        private const float dashDuration = 0.2f;
        private const float dashSpeed = 600f;

        private bool hasAirDashed = false; // for single air dash

        private PointF velocity = PointF.Empty;
        private const float gravity = 1000f;
        private const float maxFallSpeed = 2500f;
        private const float jumpForce = -460f;
        private const float moveSpeed = 250f;

        public PlayerControls(MainGame mainGame, HealthBar healthBar, PictureBox rightAttackHitBox, PictureBox leftAttackHitBox)
        {
            _mainGame = mainGame;
            _healthBar = healthBar;
            animation = new AnimationController(_mainGame.Player);

            this.rightAttackHitBox = rightAttackHitBox;
            this.leftAttackHitBox = leftAttackHitBox;

            this.rightAttackHitBox.Enabled = false;
            this.leftAttackHitBox.Enabled = false;

            rightAttackHitBox.BackColor = Color.FromArgb(120, Color.Red);
            leftAttackHitBox.BackColor = Color.FromArgb(120, Color.Blue);

            LoadAnimation();
        }

        private void LoadAnimation()
        {
            animation.AddAnimation("Idle", Properties.PlayerResources._IdleRight);
            animation.AddAnimation("IdleLeft", Properties.PlayerResources._IdleLeft);
            animation.AddAnimation("RunLeft", Properties.PlayerResources._RunLeft);
            animation.AddAnimation("RunRight", Properties.PlayerResources._RunRight);
            animation.AddAnimation("JumpLeft", Properties.PlayerResources._JumpLeft);
            animation.AddAnimation("JumpRight", Properties.PlayerResources._JumpRight);
            animation.AddAnimation("AttackLeft", Properties.PlayerResources._AttackLeft);
            animation.AddAnimation("AttackRight", Properties.PlayerResources._AttackRight);
            animation.AddAnimation("CrouchLeft", Properties.PlayerResources._CrouchLeft);
            animation.AddAnimation("CrouchRight", Properties.PlayerResources._CrouchRight);
            animation.AddAnimation("WalkCrouchLeft", Properties.PlayerResources._CrouchWalkLeft);
            animation.AddAnimation("WalkCrouchRight", Properties.PlayerResources._CrouchWalkRight);
            animation.AddAnimation("SlideLeft", Properties.PlayerResources._SlideLeft);
            animation.AddAnimation("SlideRight", Properties.PlayerResources._SlideRight);
        }

        private struct PlayerState
        {
            public float HorizontalInput;
            public bool JumpPressed;
            public bool CrouchHeld;
            public bool DashPressed;
        }

        public void UpdatePlayerMovement(float deltaTime)
        {
            AdjustHitBoxForCrouch();

            if (isAttacking && (!isCrouching || CanStandUp()) && !isCrouching && !isDashing)
            {
                attackTimer -= deltaTime;
                if (attackTimer <= 0)
                {
                    isAttacking = false;
                    rightAttackHitBox.Enabled = false;
                    rightAttackHitBox.Visible = false;
                    leftAttackHitBox.Enabled = false;
                    leftAttackHitBox.Visible = false;
                }
                UpdateSpriteLocation();
                UpdateAttackHitBoxLocation();
                return;
            }

            var input = ReadInput();

            if (InputManager.IsMouseLeftJustClicked() && IsGrounded() && (!isCrouching || CanStandUp()) && !isCrouching && !isDashing)
            {
                Console.WriteLine("Mouse left click detected!");
                isAttacking = true;
                attackTimer = attackDuration;

                if (lastFacingRight)
                {
                    animation.Play("AttackRight");
                    rightAttackHitBox.Enabled = true;
                    rightAttackHitBox.Visible = true;
                    leftAttackHitBox.Enabled = false;
                    leftAttackHitBox.Visible = false;
                }
                else
                {
                    animation.Play("AttackLeft");
                    leftAttackHitBox.Enabled = true;
                    leftAttackHitBox.Visible = true;
                    rightAttackHitBox.Enabled = false;
                    rightAttackHitBox.Visible = false;
                }

                UpdateAttackHitBoxLocation();
                return;
            }

            bool grounded = IsGrounded();
            bool ceilingAbove = IsBlockedAbove();

            bool wantsToCrouch = input.CrouchHeld && grounded || (!grounded && crouchBufferTimer > 0f) || ((isDashing || !isDashing) && ceilingAbove);

            if (wantsToCrouch)
            {
                isCrouching = true;
                crouchBufferTimer -= deltaTime;
            }
            else if (isCrouching)
            {
                // Player wants to stand — check if it’s safe
                if (CanStandUp())
                {
                    isCrouching = false;
                }
                else
                {
                    isCrouching = true; // still blocked above
                }
            }
            else
            {
                isCrouching = false;
                crouchBufferTimer = 0f;
            }

            if (isCrouching)
            {
                input.JumpPressed = false;
                input.HorizontalInput *= 0.5f;
            }
            else
            {
                crouchBufferTimer -= deltaTime;
                if (crouchBufferTimer > 0)
                {
                    isCrouching = true; // keep crouch hitbox briefly
                }
            }

            if (isDashing)
            {
                dashTimer -= deltaTime;

                int dashDirection = lastFacingRight ? 1 : -1;
                TryMove((int)(dashDirection * dashSpeed * deltaTime), 0);

                if (dashTimer <= 0f)
                {
                    isDashing = false;
                }

                UpdateSpriteLocation();
                UpdateAttackHitBoxLocation();
                return;
            }

            if (input.DashPressed && !isDashing)
            {
                bool canDash = IsGrounded() || !hasAirDashed;

                if (canDash)
                {
                    isDashing = true;
                    dashTimer = dashDuration;

                    if (!IsGrounded())
                        hasAirDashed = true;

                    animation.Play(lastFacingRight ? "SlideRight" : "SlideLeft");
                    return;
                }
            }

            UpdatePlayerAnimation(input);
            ApplyHorizontalMovement(input, deltaTime);
            ApplyGravityAndJump(input, deltaTime);
            ApplyVerticalMovement(deltaTime);
            UpdateSpriteLocation();
            UpdateAttackHitBoxLocation();
            CheckScreenEdge();

            if (IsGrounded())
            {
                hasAirDashed = false;
            }
        }

        private bool IsBlockedAbove()
        {
            Rectangle checkRect = _mainGame.playerHitBox.Bounds;
            checkRect.Y -= 10; // check slightly above
            checkRect.Height = 10;

            return CollisionManager.CheckCollisionType(checkRect, _mainGame.Obstacles) == CollisionType.Wall;
        }

        private bool CanStandUp()
        {
            Rectangle standingHitbox = _mainGame.playerHitBox.Bounds;
            standingHitbox.Y -= 33;
            standingHitbox.Height = 77;

            // Shrink hitbox slightly to avoid tiny overlaps on edges triggering forced crouch
            standingHitbox.Inflate(-4, 0);

            return CollisionManager.CheckCollisionType(standingHitbox, _mainGame.Obstacles) != CollisionType.Wall;
        }

        private void UpdatePlayerAnimation(PlayerState input)
        {
            bool movingRight = input.HorizontalInput > 0;
            bool movingLeft = input.HorizontalInput < 0;
            bool isJumping = !IsGrounded();

            if (movingRight)
                lastFacingRight = true;
            else if (movingLeft)
                lastFacingRight = false;

            if (isJumping)
            {
                animation.Play(lastFacingRight ? "JumpRight" : "JumpLeft");
            }
            else if (isCrouching && movingRight)
            {
                animation.Play("WalkCrouchRight");
            }
            else if (isCrouching && movingLeft)
            {
                animation.Play("WalkCrouchLeft");
            }
            else if (isCrouching)
            {
                animation.Play(lastFacingRight ? "CrouchRight" : "CrouchLeft");
            }
            else if (movingRight)
            {
                animation.Play("RunRight");
            }
            else if (movingLeft)
            {
                animation.Play("RunLeft");
            }
            else
            {
                animation.Play(lastFacingRight ? "Idle" : "IdleLeft");
            }
        }
        private void AdjustHitBoxForCrouch()
        {
            bool wantsSmallHitbox = isCrouching || isDashing;

            if (wantsSmallHitbox && !wasCrouching)
            {
                _mainGame.playerHitBox.Top += 33;
                _mainGame.playerHitBox.Height = 44;
            }
            else if (!wantsSmallHitbox && wasCrouching)
            {
                _mainGame.playerHitBox.Top -= 33;
                _mainGame.playerHitBox.Height = 77;
            }

            wasCrouching = wantsSmallHitbox;
        }

        private PlayerState ReadInput()
        {
            PlayerState state = new PlayerState
            {
                HorizontalInput = 0f,
                JumpPressed = false,
                CrouchHeld = false
            };

            if (InputManager.IsKeyDown(Keys.A))
                state.HorizontalInput -= 1f;
            if (InputManager.IsKeyDown(Keys.D))
                state.HorizontalInput += 1f;
            if (InputManager.IsKeyDown(Keys.Space))
                state.JumpPressed = true;
            if (InputManager.IsKeyDown(Keys.ControlKey))
                state.CrouchHeld = true;

            state.DashPressed = InputManager.IsKeyJustPressed(Keys.F);

            return state;
        }

        private void ApplyHorizontalMovement(PlayerState input, float deltaTime)
        {
            int dx = (int)(input.HorizontalInput * moveSpeed * deltaTime);
            TryMove(dx, 0);
        }

        private void ApplyGravityAndJump(PlayerState input, float deltaTime)
        {
            velocity.Y += gravity * deltaTime;
            if (velocity.Y > maxFallSpeed)
                velocity.Y = maxFallSpeed;

            if (input.JumpPressed && IsGrounded())
                velocity.Y = jumpForce;
        }

        private void ApplyVerticalMovement(float deltaTime)
        {
            int verticalMove = (int)(velocity.Y * deltaTime);
            int step = verticalMove > 0 ? 1 : -1;

            for (int i = 0; i != verticalMove; i += step)
            {
                if (!TryMove(0, step))
                {
                    velocity.Y = 0;
                    break;
                }
            }
        }

        private bool TryMove(int dx, int dy)
        {
            var newPos = new Point(
                _mainGame.playerHitBox.Location.X + dx,
                _mainGame.playerHitBox.Location.Y + dy
            );

            _mainGame.playerHitBox.Location = newPos;

            CollisionType collision = CollisionManager.CheckCollisionType(_mainGame.playerHitBox, _mainGame.Obstacles);

            switch (collision)
            {
                case CollisionType.None:
                case CollisionType.Collectible:
                case CollisionType.Enemy:
                case CollisionType.Goal:
                case CollisionType.Hazard:
                    return true;

                case CollisionType.Wall:
                    _mainGame.playerHitBox.Location = new Point(
                        _mainGame.playerHitBox.Location.X - dx,
                        _mainGame.playerHitBox.Location.Y - dy
                    );
                    return false;
            }
            return true;
        }

        private bool IsGrounded()
        {
            var testPos = new Point(_mainGame.playerHitBox.Location.X, _mainGame.playerHitBox.Location.Y + 1);
            _mainGame.playerHitBox.Location = testPos;
            bool grounded = CollisionManager.CheckCollisionType(_mainGame.playerHitBox, _mainGame.Obstacles) == CollisionType.Wall;
            _mainGame.playerHitBox.Location = new Point(testPos.X, testPos.Y - 1);
            return grounded;
        }

        private void UpdateSpriteLocation()
        {
            var hitBox = _mainGame.playerHitBox.Bounds;
            var sprite = _mainGame.Player;
            int spriteXOffset = lastFacingRight ? 11 : -11;

            int centeredX = hitBox.X + ((hitBox.Width - sprite.Width) / 2) + spriteXOffset;
            int alignedY = hitBox.Bottom - sprite.Height;

            sprite.Location = new Point(centeredX, alignedY);
        }

        private void UpdateAttackHitBoxLocation()
        {
            Rectangle playerRect = _mainGame.playerHitBox.Bounds;

            int offsetX = 10;
            int offsetY = 5;

            if (rightAttackHitBox.Enabled)
            {
                rightAttackHitBox.Location = new Point(
                    playerRect.Right + offsetX,
                    playerRect.Top - offsetY
                );
            }

            if (leftAttackHitBox.Enabled)
            {
                leftAttackHitBox.Location = new Point(
                    playerRect.Left - leftAttackHitBox.Width - offsetX,
                    playerRect.Top - offsetY
                );
            }
        }

        private void CheckScreenEdge()
        {
            var mainForm = _mainGame.FindForm() as MainGame;
            if (mainForm?.GameState == null)
            {
                Console.WriteLine("Main form or GameState is null");
                return;
            }

            // Get current level container
            var levelContainer = mainForm.ActiveControl as UserControl;
            if (levelContainer == null)
            {
                Console.WriteLine("No active level container");
                return;
            }

            // Get screen boundaries
            int screenRight = levelContainer.ClientSize.Width;
            int screenLeft = 0;
            var playerBounds = _mainGame.playerHitBox.Bounds;

            //Console.WriteLine($"Player Position: {playerBounds.Location}");
            //Console.WriteLine($"Screen Boundaries: L-{screenLeft} R-{screenRight}");

            // Right edge transition
            if (playerBounds.Right >= screenRight)
            {
                Console.WriteLine("Right edge triggered");
                TransitionLevel(mainForm, levelContainer, Direction.Right);
                return;
            }

            // Left edge transition
            if (playerBounds.Left <= screenLeft)
            {
                Console.WriteLine("Left edge triggered");
                TransitionLevel(mainForm, levelContainer, Direction.Left);
                return;
            }
        }

        private enum Direction { Left, Right }

        private void TransitionLevel(MainGame mainForm, UserControl currentLevel, Direction direction)
        {
            string currentLevelName = mainForm.GameState.CurrentLevelName;
            string newLevelName = currentLevelName == "TestLevel1" ? "TestLevel2" : "TestLevel1";

            // Calculate spawn position
            Point spawnPos = direction switch
            {
                Direction.Right => new Point(
                    50, // Spawn 50px from left in new level
                    _mainGame.playerHitBox.Top
                ),
                Direction.Left => new Point(
                    currentLevel.ClientSize.Width - _mainGame.playerHitBox.Width - 50,
                    _mainGame.playerHitBox.Top
                ),
                _ => Point.Empty
            };

            Console.WriteLine($"Transitioning to {newLevelName} at {spawnPos}");
            mainForm.SafeTransition(newLevelName, spawnPos);
        }
    }
}
