using System;
using ChainOfResponsibility.Validators;

namespace ChainOfResponsibility.Handlers
{
    public class SocialSecurityNumberValidatorHandler : Handler<User>
    {
        private readonly SocialSecurityNumberValidator socialSecurityNumberValidator = new SocialSecurityNumberValidator();

        public override void Handle(User request)
        {
            if (!socialSecurityNumberValidator.Validate(request.SocialCode))
            {
                throw new InvalidOperationException($"Invalid {nameof(request)}");
            }
            base.Handle(request);
        }
    }
}