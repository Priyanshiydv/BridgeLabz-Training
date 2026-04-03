using System;

namespace ParcelTracker
{
    internal class ParcelMenu
    {
        public void Start()
        {
            ParcelLogic logic = new ParcelLogic();

            // Default stages
            logic.AddStage("Packed");
            logic.AddStage("Shipped");
            logic.AddStage("In Transit");
            logic.AddStage("Delivered");

            logic.AddCheckpoint("Shipped", "Custom Checkpoint");

            logic.TrackParcel();
        }
    }
}
