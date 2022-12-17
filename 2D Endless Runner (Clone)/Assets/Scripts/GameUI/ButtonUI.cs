using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameUI
{
    public class ButtonUI : MonoBehaviour
    {
        public static event Action OnButtonClickMoveUpEvent;
        public static event Action OnButtonClickMoveDownEvent;

        public static event Action OnButtonClickRestartGameEvent;

        [Header("Button Controller Character")]
        [SerializeField] private Button _buttonMoveUp;
        [SerializeField] private Button _buttonMoveDown;
        [Space(10)]
        [Header("Button Discplay GameOver")]
        [SerializeField] private Button _buttonRestartGame;

        private void Start()
        {
            _buttonMoveUp.onClick.RemoveAllListeners();
            _buttonMoveUp.onClick.AddListener(OnButtonClickMoveUp);

            _buttonMoveDown.onClick.RemoveAllListeners();
            _buttonMoveDown.onClick.AddListener(OnButtonClickMoveDown);

            _buttonRestartGame.onClick.RemoveAllListeners();
            _buttonRestartGame.onClick.AddListener(OnButtonClickRestartGame);
        }

        private void OnButtonClickMoveUp()
        {
            OnButtonClickMoveUpEvent?.Invoke();
        }
        private void OnButtonClickMoveDown()
        {
            OnButtonClickMoveDownEvent?.Invoke();
        }
        private void OnButtonClickRestartGame()
        {
            OnButtonClickRestartGameEvent?.Invoke();
        }
    }
}