namespace VisitorDesignPattern
{
    public class EyeDoctor : Visitor
    {
        public override void Visit(VisitableObject akid)
        {
            Kid kid = (Kid)akid;
            kid.EyeStatus = "Status updated from EyeDoctor - " +
            "Message from Dr.WANG, Eye Infections found for " + kid.Name + "." +
            "Please schedule an appointment asap";
        }
    }
}