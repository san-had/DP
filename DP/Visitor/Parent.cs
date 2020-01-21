using System;

namespace VisitorDesignPattern
{
    public class Parent : Visitor
    {
        public override void Visit(VisitableObject akid)
        {
            Kid kid = (Kid)akid;

            kid.EyeStatus += Environment.NewLine +
            "Status updated from Parent -- This is " + kid.Name +
            "'s parent, I updated the EyeStatus.";

            kid.SpeechStatus += Environment.NewLine +
            "Status updated from Parent -- This is " + kid.Name +
            "'s parent, I updated the SpeechStatus.";
        }
    }
}