namespace Asteroids
{
    public interface IWeapon
    {
        int CountAmmunition { get; }
        IAmmunition Ammunition { get; }
    }
}
