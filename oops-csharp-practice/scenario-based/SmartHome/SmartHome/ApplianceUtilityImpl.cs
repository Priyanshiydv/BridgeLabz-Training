using System;

namespace SmartHome
{
    internal class ApplianceUtilityImpl : IControllable
    {
        private Appliance appliance;

        public ApplianceUtilityImpl(Appliance appliance)
        {
            this.appliance = appliance;
        }

        public void TurnOn()
        {
            if (appliance.Type == "Light")
                Console.WriteLine("Light is turned ON with bright light ");

            else if (appliance.Type == "Fan")
                Console.WriteLine("Fan is turned ON at medium speed ");

            else if (appliance.Type == "AC")
                Console.WriteLine("AC is turned ON and cooling the room ");
        }

        public void TurnOff()
        {
            Console.WriteLine(appliance.Type + " is turned OFF");
        }
    }
}
