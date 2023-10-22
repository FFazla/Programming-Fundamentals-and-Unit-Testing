namespace _8.TicketPrice;
class Program
{
    static void Main(string[] args)
    {
        double StudentTicket = 1.00;
        double RegularTicket = 1.60;
        string type = Console.ReadLine();
        if (type == "student")
        {
            Console.WriteLine($"${StudentTicket:F2}");
        }
        else if ( type == "regular")
        {
            Console.WriteLine($"${RegularTicket:F2}");
        }
        else
        {
            Console.WriteLine("Invalid ticket type!");
        }
    }
}

