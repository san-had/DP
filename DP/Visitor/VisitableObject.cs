namespace VisitorDesignPattern
{
    public abstract class VisitableObject
    {
        public void AcceptVisitor(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}