using Enemy;
using System.Collections;
using UnityEngine;

namespace SpawnGameObject
{
    public class EnemyActivator : MonoBehaviour
    {
        [SerializeField] private EnemyDefould[] _enemyPrefabs;
        private int _countEnemy;

        private const float WAIT_TIME = 3f;

        private void Start()
        {
            _countEnemy = _enemyPrefabs.Length;
        }

        private void OnEnable()
        {
            StartActiveEnemy();
            foreach (var enemy in _enemyPrefabs){
                enemy.OnEnemyIsNotActiveEvent += SetCurrentCountEnemy;
            }
        }

        private void OnDisable()
        {
            foreach (var enemy in _enemyPrefabs){
                enemy.OnEnemyIsNotActiveEvent -= SetCurrentCountEnemy;
            }
        }

        private void StartActiveEnemy()
        {
            foreach (var item in _enemyPrefabs){
                item.gameObject.SetActive(true);
            }
        }

        private void SetCurrentCountEnemy(int value)
        {
            StartCoroutine(SetCurrentCountEnemyRoutine(value));
        }

        private IEnumerator SetCurrentCountEnemyRoutine(int value)
        {
            yield return new WaitForSeconds(WAIT_TIME);

            if (value > 0)
                _countEnemy -= value;

            if (_countEnemy <= 0)
                this.gameObject.SetActive(false);
        }
    }
}