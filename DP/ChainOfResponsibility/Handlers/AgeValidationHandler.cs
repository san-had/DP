using System;

namespace ChainOfResponsibility.Handlers
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.DateOfBirth.Year < 1987)
            {
                throw new Exception($" {nameof(request)}");
            }

            base.Handle(request);
        }
    }
}