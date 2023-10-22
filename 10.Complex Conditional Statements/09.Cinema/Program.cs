namespace _09.Cinema;
class Program
{
    static void Main(string[] args)
    {
        string movie = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int seats = int.Parse(Console.ReadLine());


        int totalSeats = rows * seats;

        double price = 0;
        if ( movie == "Premiere")
        {
            price = totalSeats * 12.00; 
        }
        else if (movie == "Normal")
        {
           price = totalSeats * 7.50;
        }
        else if (movie == "Discount")
        {
            price = totalSeats * 5.00;
        }

        Console.WriteLine($"{price:F2}");

    }
}

