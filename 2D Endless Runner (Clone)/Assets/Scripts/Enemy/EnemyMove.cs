using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed * Time.fixedDeltaTime);
    }
}