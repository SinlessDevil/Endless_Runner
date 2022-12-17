namespace Enemy
{
    public sealed class HugePrikles : EnemyDefould
    {
        public override void Accept(ICollisonVisitor collison)
        {
            collison.Visit(this);
            SetPositionEnemy();
        }
    }
}