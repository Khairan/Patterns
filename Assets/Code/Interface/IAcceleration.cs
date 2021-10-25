namespace Asteroids
{
    public interface IAcceleration
    {
        float Acceleration { get; }
        void AddAcceleration();
        void RemoveAcceleration();
    }
}
