using System;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public event Action<int> OnHealthChangeEvent;
    public event Action<bool> OnShowScreenGameOverEvent;

    [SerializeField] private int _maxHealth = 10;
    private int _health;

    private void Start()
    {
        _health = _maxHealth;
    }

    public void ApplyDamage(int damage)
    {
        if (damage < 0){
            return;
        }

        if(_health <= damage){
            StopAllCoroutines();
            OnShowScreenGameOverEvent?.Invoke(true);
            return;
        }

        _health -= damage;

        if (OnHealthChangeEvent != null){
            OnHealthChange(_health);
        }
    }

    private void OnHealthChange(int _health)
    {
        OnHealthChangeEvent?.Invoke(_health);
    }
}