using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IPhoneBuilder
    {
        MobilePhone Phone { get; }

        void BuildScreen();

        void BuildBattery();

        void BuildOS();

        void BuildStylus();
    }
}