using UnityEngine;


namespace Asteroids
{
    public class Reference
    {
        #region Fields

        private Player _player;
        private Camera _mainCamera;
        private GameObject _bullet;

        #endregion


        #region Properties

        public Camera MainCamera
        {
            get
            {
                if (_mainCamera == null)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
        }

        public Player Player
        {
            get
            {
                if (_player == null)
                {
                    var gameObject = Resources.Load<Player>("Player");
                    _player = Object.Instantiate(gameObject);
                }

                return _player;
            }
        }

        public GameObject Bullet
        {
            get
            {
                if (_bullet == null)
                {
                    _bullet = Resources.Load<GameObject>("Bullet");
                }

                return _bullet;
            }
        }

        #endregion

    }
}