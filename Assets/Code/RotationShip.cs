using UnityEngine;


namespace Asteroids
{
    internal sealed class RotationShip : IRotation
    {
        #region Fields

        private readonly Transform _transform;

        #endregion

        
        #region Methods

        public RotationShip(Transform transform)
        {
            _transform = transform;
        }
        
        public void Rotation(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _transform.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        #endregion
    }
}
