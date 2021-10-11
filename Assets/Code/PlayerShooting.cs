using UnityEngine;


namespace Asteroids
{
    internal sealed class PlayerShooting : IShooting
    {
        #region Fields

        private Rigidbody2D _bullet;
        private Transform _barrel;
        private float _force;

        #endregion


        #region Methods

        public PlayerShooting(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void Shoot()
        {
            var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }

        #endregion


    }
}
