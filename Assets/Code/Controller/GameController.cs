using Asteroids.Object_Pool;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region Fields

        private List<IExecute> _executeObjects;
        private Reference _reference;

        #endregion

        
        #region Methods

        private void Awake()
        {
            _executeObjects = new List<IExecute>();

            _reference = new Reference();
            
            var inputController = new InputController(_reference.Player, _reference.MainCamera);
            _executeObjects.Add(inputController);
                        
            var cameraController = new CameraController(_reference.Player.transform, _reference.MainCamera.transform);
            _executeObjects.Add(cameraController);

            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }

        private void Update()
        {
            for (var i = 0; i < _executeObjects.Count; i++)
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
