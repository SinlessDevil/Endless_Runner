namespace Enemy
{
    public sealed class BigPrickles : EnemyDefould
    {
        public override void Accept(ICollisonVisitor collison)
        {
            collison.Visit(this);
            SetPositionEnemy();
        }
    }
}