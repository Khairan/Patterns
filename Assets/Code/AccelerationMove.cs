using UnityEngine;


namespace Asteroids
{
    internal sealed class AccelerationMove : MoveTransform, IAcceleration
    {
        #region Fields

        public float Acceleration { get; set; }

        #endregion


        #region Methods

        public AccelerationMove(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            Acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += Acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= Acceleration;
        }

        #endregion
    }
}
