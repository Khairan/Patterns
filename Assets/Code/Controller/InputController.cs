using UnityEngine;


namespace Asteroids
{
    public sealed class InputController : IExecute
    {
        #region Fields

        private readonly Player _player;
        private readonly Camera _mainCamera;
        
        #endregion


        #region Methods

        public InputController(Player player, Camera mainCamera)
        {
            _player = player;
            _mainCamera = mainCamera;
        }

        public void Execute()
        {
            var direction = Input.mousePosition - _mainCamera.WorldToScreenPoint(_player.transform.position);
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            
            _player.Move(direction, horizontal, vertical);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _player.Ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _player.Ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _player.Shoot();
            }
        }

        #endregion
    }
}
