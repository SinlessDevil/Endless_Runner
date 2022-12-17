using System.Collections;
using UnityEngine;

namespace SpawnGameObject
{
    public class EnemyFabricMono : MonoBehaviour
    {
        [Header("--------- Settings Pool Mono ---------")]
        [SerializeField] private int _poolCount;
        [SerializeField] private bool _autoExpand;
        [SerializeField] private float _startWaitTime = 5f;
        [Space(10)]
        [SerializeField] private EnemyActivator[] _variantPrefabs;

        private PoolMono<EnemyActivator> _pool;

        private const float DECREMENT_WAIT_TIME = 0.2f;
        private const float MIN_WAIT_TIME = 2f;

        private void Start()
        {
            _pool = new PoolMono<EnemyActivator>(_variantPrefabs, _poolCount, this.transform);
            _pool.autoExpand = _autoExpand;

            StartCoroutine(SpawnActivator());
        }

        private IEnumerator SpawnActivator()
        {
            while (true)
            {
                var variant = _pool.GetFreeElement();
                variant.transform.position = this.transform.position;

                yield return new WaitForSeconds(_startWaitTime);

                if (_startWaitTime > MIN_WAIT_TIME)
                    _startWaitTime -= DECREMENT_WAIT_TIME;
            }
        }
    }
}