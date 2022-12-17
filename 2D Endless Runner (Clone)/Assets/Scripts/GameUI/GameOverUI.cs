using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameUI
{
    public class GameOverUI : MonoBehaviour
    {
        [Header("Displays")]
        [SerializeField] private GameObject _gameOverDisplay;
        [SerializeField] private GameObject _gamePlayDisplay;
        [Space(10)]
        [Header("References")]
        [SerializeField] private CharacterHealth _characterHealth;
        private void Start()
        {
            if (_characterHealth == null)
                throw new System.NullReferenceException("GameObect CharacterHealth has not been assigned");
        }

        private void OnEnable()
        {
            _characterHealth.OnShowScreenGameOverEvent += ShowScreen;
            ButtonUI.OnButtonClickRestartGameEvent += RestartThisGame;
        }

        private void OnDisable()
        {
            _characterHealth.OnShowScreenGameOverEvent -= ShowScreen;
            ButtonUI.OnButtonClickRestartGameEvent -= RestartThisGame;
        }

        private void ShowScreen(bool isActive)
        {
            _gameOverDisplay.SetActive(isActive);
            _gamePlayDisplay.SetActive(!isActive);

            Time.timeScale = Convert.ToInt32(isActive);
        }

        private void RestartThisGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}