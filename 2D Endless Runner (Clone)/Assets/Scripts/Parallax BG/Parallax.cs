using UnityEngine;

namespace Parallax{
    public class Parallax : MonoBehaviour{
        [SerializeField] private ObjectParallax[] _backgroundObjects;

        private const float END_POSITION = - 109.2f;
        private const float START_POSITION = 0f;

        private Vector2 _startPosition;

        private void Start(){
            _startPosition = new Vector2(START_POSITION, transform.position.y);
        }

        private void FixedUpdate(){
            MoveTo(END_POSITION);
        }

        private void MoveTo(float endPosition){
            for (int i = 0; i < _backgroundObjects.Length; i++){
                _backgroundObjects[i].transform.Translate(Vector2.left * _backgroundObjects[i].speed * Time.fixedDeltaTime);
                if (_backgroundObjects[i].transform.position.x <= endPosition){

                    _startPosition.y = _backgroundObjects[i].transform.position.y;
                    _backgroundObjects[i].transform.position = _startPosition;
                }
            }
        }
    }
}