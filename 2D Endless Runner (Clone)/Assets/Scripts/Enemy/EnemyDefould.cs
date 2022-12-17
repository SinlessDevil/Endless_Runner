using System;
using System.Collections;
using UnityEngine;

namespace Enemy
{
    [RequireComponent(typeof(CircleCollider2D),typeof(EnemyMove))]
    public abstract class EnemyDefould : EnemyCollison
    {
        public event Action<int> OnEnemyIsNotActiveEvent;

        [SerializeField] private int _damage;
        [SerializeField] private GameObject _bodyComponent;
        public int scoreLvl;

        private CircleCollider2D _collider;
        private EnemyMove _enemyMove;
        private ParticleSystem _deathEffect;

        private Vector2 _startPosition;

        private const float WAIT_TIME = 2f;

        private void Start(){
            _collider = GetComponent<CircleCollider2D>();
            _enemyMove = GetComponent<EnemyMove>();
            _deathEffect = GetComponentInChildren<ParticleSystem>();

            _startPosition = transform.position;
        }

        private void OnTriggerEnter2D(Collider2D collision){
            if (collision.gameObject.TryGetComponent(out CharacterHealth character)){
                character.ApplyDamage(_damage);

                StartCoroutine(ReloudEnemy());
            }
        }

        private IEnumerator ReloudEnemy(){
            PlayEffect();

            SetStateEnemy(false);

            yield return new WaitForSeconds(WAIT_TIME);

            SetPositionEnemy();

            SetStateEnemy(true);
        }

        private void PlayEffect(){
            _deathEffect.Play();
        }
        protected void SetPositionEnemy()
        {
            transform.position = _startPosition;
            gameObject.SetActive(false);

            OnEnemyIsNotActiveEvent?.Invoke(1);
        }
        private void SetStateEnemy(bool isActive)
        {
            _collider.enabled = isActive;
            _bodyComponent.SetActive(isActive);
           _enemyMove.enabled = isActive;
        }
    }
}