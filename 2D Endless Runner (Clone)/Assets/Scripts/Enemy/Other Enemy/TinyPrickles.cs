namespace Enemy
{
    public sealed class TinyPrickles : EnemyDefould
    {
        public override void Accept(ICollisonVisitor collison)
        {
            collison.Visit(this);
            SetPositionEnemy();
        }
    }
}