using Enemy;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager;
    private void Start()
    {
        if (_scoreManager == null)
            throw new System.NullReferenceException("GameObect ScoreManager has not been assigned");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.TryGetComponent(out EnemyCollison enemy))
        {
            enemy.Accept(_scoreManager);
        }
    }
}