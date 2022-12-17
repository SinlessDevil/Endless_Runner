using GameUI;
using UnityEngine;

namespace Characters{
    public class MyCharacterController : MonoBehaviour{
        private Character _character;

        private const int DIRECTION_UP = 1;
        private const int DIRECTION_DOWN = -1;

        [SerializeField] private const float MAX_OFFSET_HEIGHT = 5f;
        [SerializeField] private const float MIN_OFFSET_HEIGHT = -5f;
        private void Start()
        {
            _character = FindObjectOfType<Character>();
        }

        private void OnEnable(){
            ButtonUI.OnButtonClickMoveUpEvent += MoveUp;
            ButtonUI.OnButtonClickMoveDownEvent += MoveDown;
        }
        private void OnDisable(){
            ButtonUI.OnButtonClickMoveUpEvent -= MoveUp;
            ButtonUI.OnButtonClickMoveDownEvent -= MoveDown;
        }

        private void MoveUp(){
            if (_character.transform.position.y < MAX_OFFSET_HEIGHT)
                _character.MoveTo(DIRECTION_UP);
        }
        private void MoveDown(){
            if (_character.transform.position.y > MIN_OFFSET_HEIGHT)
                _character.MoveTo(DIRECTION_DOWN);
        }
    }
}