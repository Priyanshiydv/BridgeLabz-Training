using System;

namespace ParcelTracker
{
    
    //Implements Singly Linked List logic
    internal class ParcelLogic
    {
        private StageNode head; // First stage

        // Add initial stage or append at end
        public void AddStage(string stage)
        {
            StageNode newNode = new StageNode(stage);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StageNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Add custom checkpoint after a given stage
        public void AddCheckpoint(string afterStage, string newStage)
        {
            StageNode temp = head;

            while (temp != null)
            {
                if (temp.StageName == afterStage)
                {
                    StageNode node = new StageNode(newStage);
                    node.Next = temp.Next;
                    temp.Next = node;
                    Console.WriteLine("Checkpoint added.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Stage not found.");
        }

        // Forward tracking
        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel lost (no stages found).");
                return;
            }

            StageNode temp = head;
            Console.WriteLine("Parcel Tracking:");

            while (temp != null)
            {
                Console.WriteLine(" → " + temp.StageName);
                temp = temp.Next;
            }
        }
    }
}
