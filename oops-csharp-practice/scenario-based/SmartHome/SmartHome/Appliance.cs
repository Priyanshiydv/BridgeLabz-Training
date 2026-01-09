using System;

namespace SmartHome
{
    internal class Appliance
    {
        public int ApplianceId { get; set; }
        public string ApplianceName { get; set; }
        public string Type { get; set; } // Light / Fan / AC

        public override string ToString()
        {
            return "Appliance ID: " + ApplianceId +
                   "\nAppliance Name: " + ApplianceName +
                   "\nAppliance Type: " + Type;
        }
    }
}
