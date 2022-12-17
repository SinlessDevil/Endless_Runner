using Enemy;
public interface ICollisonVisitor
{
    void Visit(TinyPrickles collison);
    void Visit(BigPrickles collison);
    void Visit(HugePrikles collison);
}