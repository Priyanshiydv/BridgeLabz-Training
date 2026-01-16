using System;
namespace TrafficManager
{
    internal class Vehicle
    {
        public string Number;
        public Vehicle Next;

        public Vehicle(string number)
        {
            Number = number;
            Next = null;
        }
    }
}
