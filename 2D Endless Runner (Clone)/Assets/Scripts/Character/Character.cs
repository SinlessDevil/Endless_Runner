using UnityEngine;

namespace Characters
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _offset;
        [SerializeField] private ParticleSystem _effectMove;
        private Vector2 _currentOffsetPos;

        private void FixedUpdate(){
            transform.position = Vector2.MoveTowards(transform.position, _currentOffsetPos, _speed * Time.fixedDeltaTime);
        }

        public void MoveTo(int direction){
            _currentOffsetPos = new Vector2(transform.position.x, transform.position.y + (_offset * direction));
            PlayEffect();
        }

        private void PlayEffect(){
            _effectMove.Play();
        }
    }
}