using System;
namespace TrafficManager
{
    internal class TrafficLogic
    {
        // Circular Linked List (Roundabout)
        private Vehicle last;

        // Queue (Waiting vehicles)
        private string[] queue;
        private int front, rear, size;

        public TrafficLogic()
        {
            // Queue setup
            size = 5;
            queue = new string[size];
            front = 0;
            rear = -1;

            // Roundabout empty
            last = null;
        }

        // ================= QUEUE LOGIC =================

        public void AddToQueue(string vehicle)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue Overflow! Waiting area full.");
                return;
            }

            queue[++rear] = vehicle;
            Console.WriteLine("Vehicle added to queue: " + vehicle);
        }

        public string RemoveFromQueue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Underflow! No vehicles waiting.");
                return null;
            }

            return queue[front++];
        }

        // ================= ROUNDABOUT LOGIC =================

        public void EnterRoundabout()
        {
            string vehicleNumber = RemoveFromQueue();
            if (vehicleNumber == null)
                return;

            Vehicle newVehicle = new Vehicle(vehicleNumber);

            if (last == null)
            {
                last = newVehicle;
                last.Next = last;
            }
            else
            {
                newVehicle.Next = last.Next;
                last.Next = newVehicle;
                last = newVehicle;
            }

            Console.WriteLine("Vehicle entered roundabout: " + vehicleNumber);
        }

        public void ExitRoundabout()
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            if (last.Next == last)
            {
                Console.WriteLine("Vehicle exited: " + last.Number);
                last = null;
            }
            else
            {
                Vehicle first = last.Next;
                Console.WriteLine("Vehicle exited: " + first.Number);
                last.Next = first.Next;
            }
        }

        public void DisplayRoundabout()
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Vehicle temp = last.Next;
            Console.Write("Roundabout Vehicles: ");

            do
            {
                Console.Write(temp.Number + " ");
                temp = temp.Next;
            } while (temp != last.Next);

            Console.WriteLine();
        }
    }
}
