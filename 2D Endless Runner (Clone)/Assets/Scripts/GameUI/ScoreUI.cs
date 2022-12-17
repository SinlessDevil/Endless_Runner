using UnityEngine;

namespace GameUI
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TMPro.TMP_Text _scoreCount;
        private int currentScore;

        private void OnEnable()
        {
            ScoreManager.OnScoreChangeEvent += UpdateScoreCount;
        }

        private void OnDisable()
        {
            ScoreManager.OnScoreChangeEvent -= UpdateScoreCount;
        }

        private void UpdateScoreCount(int value)
        {
            currentScore += value;
            _scoreCount.text = currentScore.ToString();
        }
    }
}