using UnityEngine;

namespace GameUI
{
    public class HealthBarUI : MonoBehaviour
    {
        [SerializeField] private CharacterHealth _characterHealth;
        [SerializeField] private TMPro.TMP_Text _countHealth;

        private void Start()
        {
            if(_characterHealth == null)
                throw new System.NullReferenceException("GameObect EntityHealth has not been assigned");
        }

        private void OnEnable()
        {
            _characterHealth.OnHealthChangeEvent += UpdateHealthBar;
        }

        private void OnDisable()
        {
            _characterHealth.OnHealthChangeEvent -= UpdateHealthBar;
        }

        private void UpdateHealthBar(int value)
        {
            if (_characterHealth == null) return;
            _countHealth.text = value.ToString();
        }
    }
}