using BuilderPattern.Builder;
using BuilderPattern.Helpers;
using BuilderPattern.Product;
using OperatingSystem = BuilderPattern.Helpers.OperatingSystem;

namespace BuilderPattern.ConcreteBuilders
{
    public class AndroidPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone Phone => new MobilePhone("Android Phone");

        public void BuildBattery()
        {
            Phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = OperatingSystem.ANDROID;
        }

        public void BuildScreen()
        {
            Phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildStylus()
        {
            Phone.PhoneStylus = Stylus.YES;
        }
    }
}