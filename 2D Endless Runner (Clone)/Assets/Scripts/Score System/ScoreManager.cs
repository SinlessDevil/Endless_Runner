using Enemy;
using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour, ICollisonVisitor
{
    public static event Action<int> OnScoreChangeEvent;
    public void Visit(TinyPrickles collison)
    {
        OnScoreChangeEvent?.Invoke(collison.scoreLvl);
    }

    public void Visit(BigPrickles collison)
    {
        OnScoreChangeEvent?.Invoke(collison.scoreLvl);
    }

    public void Visit(HugePrikles collison)
    {
        OnScoreChangeEvent?.Invoke(collison.scoreLvl);
    }
}