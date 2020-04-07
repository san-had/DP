using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public class UserProcessor
    {
        public bool Register(User user)
        {
            try
            {
                var handler = new SocialSecurityNumberValidatorHandler();

                handler.SetNext(new AgeValidationHandler());

                handler.Handle(user);
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
    }
}