using UnityEngine;


namespace Asteroids.ObjectPool
{
    internal interface IViewServices
    {
        void Create(GameObject prefab);

        void Destroy(GameObject prefab);
    }
}