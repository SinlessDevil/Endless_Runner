using UnityEngine;

public abstract class EnemyCollison : MonoBehaviour
{
    public abstract void Accept(ICollisonVisitor collison);
}
