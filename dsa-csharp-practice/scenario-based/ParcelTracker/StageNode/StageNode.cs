using System;

namespace ParcelTracker
{
    // Represents one stage in parcel delivery
    // Each stage is a node in a singly linked list
    internal class StageNode
    {
        public string StageName;   // Packed, Shipped, etc.
        public StageNode Next;     // Pointer to next stage

        public StageNode(string stage)
        {
            StageName = stage;
            Next = null;
        }
    }
}
