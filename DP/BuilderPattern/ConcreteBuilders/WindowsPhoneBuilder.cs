using BuilderPattern.Builder;
using BuilderPattern.Helpers;
using BuilderPattern.Product;
using OperatingSystem = BuilderPattern.Helpers.OperatingSystem;

namespace BuilderPattern.ConcreteBuilders
{
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone Phone => new MobilePhone("Windows Phone");

        public void BuildBattery()
        {
            Phone.PhoneBattery = Battery.MAH_2000;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = OperatingSystem.WINDOWS_PHONE;
        }

        public void BuildScreen()
        {
            Phone.PhoneScreen = ScreenType.ScreenType_TOUCH_CAPACITIVE;
        }

        public void BuildStylus()
        {
            Phone.PhoneStylus = Stylus.NO;
        }
    }
}