using System;

class TicketNode
{
    public int TicketId;
    public string Customer;
    public string Movie;
    public int Seat;
    public TicketNode Next;

    public TicketNode(int id, string cust, string movie, int seat)
    {
        TicketId = id;
        Customer = cust;
        Movie = movie;
        Seat = seat;
        Next = null;
    }
}

class TicketSystem
{
    private TicketNode head;

    public void AddTicket(int id, string cust, string movie, int seat)
    {
        TicketNode node = new TicketNode(id, cust, movie, seat);

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    public void DisplayTickets()
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            Console.WriteLine("Ticket " + temp.TicketId +
                              " Customer " + temp.Customer +
                              " Movie " + temp.Movie +
                              " Seat " + temp.Seat);
            temp = temp.Next;
        } while (temp != head);
    }

    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Total Tickets: " + count);
    }
}

class Program
{
    static void Main()
    {
        TicketSystem ts = new TicketSystem();

        ts.AddTicket(1, "Ravi", "Avengers", 12);
        ts.AddTicket(2, "Amit", "Batman", 15);

        ts.DisplayTickets();
        ts.CountTickets();
    }
}
