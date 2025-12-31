using System;

class HotelBooking
{
    string guestName;
    string roomType;
    int nights;

    HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    HotelBooking(string g, string r, int n)
    {
        guestName = g;
        roomType = r;
        nights = n;
    }

    HotelBooking(HotelBooking h)
    {
        guestName = h.guestName;
        roomType = h.roomType;
        nights = h.nights;
    }

    void Display()
    {
        Console.WriteLine("Guest: " + guestName);
        Console.WriteLine("Room: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }

    static void Main()
    {
        HotelBooking h1 = new HotelBooking("Riya", "Deluxe", 3);
        HotelBooking h2 = new HotelBooking(h1);
        h2.Display();
    }
}
