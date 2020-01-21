namespace VisitorDesignPattern
{
    public class SLP : Visitor
    {
        public override void Visit(VisitableObject akid)
        {
            Kid kid = (Kid)akid;
            kid.SpeechStatus = "Status updated from SLP - This is Dr.FONG, " +
            kid.Name + " did a good job on the speech exam.";
        }
    }
}