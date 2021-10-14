using Asteroids.Object_Pool;
using UnityEngine;


namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region Fields

        private ListExecuteObject _executeObjects;
        private Reference _reference;

        #endregion

        
        #region Methods

        private void Awake()
        {
            _executeObjects = new ListExecuteObject();

            _reference = new Reference();
            
            var inputController = new InputController(_reference.Player, _reference.MainCamera);
            _executeObjects.AddExecuteObject(inputController);
                        
            var cameraController = new CameraController(_reference.Player.transform, _reference.MainCamera.transform);
            _executeObjects.AddExecuteObject(cameraController);

            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }

        private void Update()
        {
            for (var i = 0; i < _executeObjects.Length; i++)
            {
                var interactiveObject = _executeObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
        }
        
        #endregion
    }
}
