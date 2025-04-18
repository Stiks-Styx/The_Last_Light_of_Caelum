﻿using StyxEngine.Components;
using StyxEngine.Utils;
using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace StyxEngine.Engine
{
    public class PlayerControls
    {
        private MainGame _mainGame;
        private AnimationController animation;
        private HealthBar _healthBar;

        // Attack hitboxes for each direction.
        private PictureBox rightAttackHitBox;
        private PictureBox leftAttackHitBox;

        private bool lastFacingRight = true;
        private bool isAttacking = false;
        private float attackTimer = 0f;
        private const float attackDuration = .25f; // in seconds (adjust to match the animation length)

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

            // Store references to the attack hitboxes.
            this.rightAttackHitBox = rightAttackHitBox;
            this.leftAttackHitBox = leftAttackHitBox;

            // Ensure both hitboxes are disabled initially.
            this.rightAttackHitBox.Enabled = false;
            this.leftAttackHitBox.Enabled = false;

            rightAttackHitBox.BackColor = Color.FromArgb(120, Color.Red); // semi-transparent red
            leftAttackHitBox.BackColor = Color.FromArgb(120, Color.Blue); // semi-transparent blue

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
        }

        private struct PlayerState
        {
            public int HorizontalInput;
            public bool JumpPressed;
        }

        public void UpdatePlayerMovement(float deltaTime)
        {
            // If the player is currently attacking, update the timer
            // and update the sprite and hitbox locations.
            if (isAttacking)
            {
                attackTimer -= deltaTime;
                if (attackTimer <= 0)
                {
                    isAttacking = false;
                    // Disable and hide both hitboxes when the attack is finished.
                    rightAttackHitBox.Enabled = false;
                    rightAttackHitBox.Visible = false;
                    leftAttackHitBox.Enabled = false;
                    leftAttackHitBox.Visible = false;
                }
                UpdateSpriteLocation();
                UpdateAttackHitBoxLocation();
                return; // Skip further movement while attacking.
            }

            var input = ReadInput();

            // Only allow an attack if the player is grounded.
            if (InputManager.IsMouseLeftJustClicked() && IsGrounded())
            {
                Console.WriteLine("Mouse left click detected!");
                isAttacking = true;
                attackTimer = attackDuration;

                if (lastFacingRight)
                {
                    animation.Play("AttackRight");
                    rightAttackHitBox.Enabled = true;
                    rightAttackHitBox.Visible = true;  // Make it visible
                    leftAttackHitBox.Enabled = false;
                    leftAttackHitBox.Visible = false;
                }
                else
                {
                    animation.Play("AttackLeft");
                    leftAttackHitBox.Enabled = true;
                    leftAttackHitBox.Visible = true;   // Make it visible
                    rightAttackHitBox.Enabled = false;
                    rightAttackHitBox.Visible = false;
                }
                // Update hitbox location immediately on attack start.
                UpdateAttackHitBoxLocation();
                return;
            }

            UpdatePlayerAnimation(input);
            ApplyHorizontalMovement(input, deltaTime);
            ApplyGravityAndJump(input, deltaTime);
            ApplyVerticalMovement(deltaTime);
            UpdateSpriteLocation();
            UpdateAttackHitBoxLocation();
        }

        private void UpdatePlayerAnimation(PlayerState input)
        {
            bool movingRight = input.HorizontalInput > 0;
            bool movingLeft = input.HorizontalInput < 0;
            bool isJumping = !IsGrounded();
            bool isCrouching = false;

            if (movingRight)
                lastFacingRight = true;
            else if (movingLeft)
                lastFacingRight = false;

            if (isJumping)
                animation.Play(lastFacingRight ? "JumpRight" : "JumpLeft");
            else if (movingRight)
                animation.Play("RunRight");
            else if (movingLeft)
                animation.Play("RunLeft");
            else if (isCrouching)
                /* Crouching Animation */
                ;
            else
                animation.Play(lastFacingRight ? "Idle" : "IdleLeft");
        }

        private PlayerState ReadInput()
        {
            PlayerState state = new PlayerState
            {
                HorizontalInput = 0,
                JumpPressed = false
            };

            if (InputManager.IsKeyDown(Keys.A))
                state.HorizontalInput -= 1;
            if (InputManager.IsKeyDown(Keys.D))
                state.HorizontalInput += 1;
            if (InputManager.IsKeyDown(Keys.Space))
                state.JumpPressed = true;
            if (InputManager.IsKeyDown(Keys.S))
            {
                // TODO implement going down a platform
            }
            if (InputManager.IsKeyDown(Keys.C))
            {
                // TODO implement toggle crouch
            }

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
                    // Revert the move if there is a collision.
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

        // This method updates the location of the active attack hitbox so that it follows the player's position.
        private void UpdateAttackHitBoxLocation()
        {
            Rectangle playerRect = _mainGame.playerHitBox.Bounds;

            int offsetX = 10;
            int offsetY = 5;

            if (rightAttackHitBox.Enabled)
            {
                // Position to the right side of the player hitbox
                rightAttackHitBox.Location = new Point(
                    playerRect.Right + offsetX,
                    playerRect.Top - offsetY
                );
            }

            if (leftAttackHitBox.Enabled)
            {
                // Position to the left side of the player hitbox
                leftAttackHitBox.Location = new Point(
                    playerRect.Left - leftAttackHitBox.Width - offsetX,
                    playerRect.Top - offsetY
                );
            }
        }
    }
}
