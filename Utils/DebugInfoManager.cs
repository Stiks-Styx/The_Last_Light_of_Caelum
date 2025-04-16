using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyxEngine.Components;

namespace StyxEngine.Utils
{
    public class DebugInfoManager
    {
        private MainGame _mainGame;
        public DebugInfoManager(MainGame game)
        {
            _mainGame = game;
        }

        public void DebugInfoUpdate(int currentHP)
        {
            var player = _mainGame.playerHitBox;

            CollisionType collisionType = CollisionManager.CheckCollisionType(player, _mainGame.Obstacles);

            _mainGame._playerPositionDebug.Text = $"Player Position: X: {player.Location.X}, {player.Location.Y}";
            _mainGame._playerHealthDebug.Text = $"Player Health: {currentHP}";

            _mainGame._collisionTypeDebug.Text = $"Collision Type: {collisionType}";

            if (collisionType != CollisionType.None)
            {
                _mainGame._collisionStatusDebug.Text = $"Collision Status: {true}";
            }
            else
            {
                _mainGame._collisionStatusDebug.Text = $"Collision Status: {false}";

            }
        }
    }
}
