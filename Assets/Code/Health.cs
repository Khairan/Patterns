namespace Asteroids
{
    public sealed class Health
    {
        #region Fields

        public float Max { get; }
        public float Current { get; private set; }

        #endregion


        #region Methods

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }

        #endregion
    }
}