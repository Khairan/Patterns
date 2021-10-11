using UnityEngine;


namespace Asteroids
{
    public sealed class Player : MonoBehaviour
    {
        #region Fields

        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        
        internal Ship Ship { get; private set; }

        private PlayerShooting _playerShooting;

        #endregion


        #region Methods

        private void Start()
        {
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            Ship = new Ship(moveTransform, rotation);

            _playerShooting = new PlayerShooting(_bullet, _barrel, _force);
        }

        public void Move(Vector3 direction, float horizontal, float vertical)
        {
            Ship.Rotation(direction);
            Ship.Move(horizontal, vertical, Time.deltaTime);
        }

        public void Shoot()
        {
            _playerShooting.Shoot();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
        
        #endregion
    }
}