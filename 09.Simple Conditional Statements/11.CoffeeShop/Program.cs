namespace _11.CoffeeShop;
class Program
{
    static void Main(string[] args)
    {
        
        string drink = Console.ReadLine();
        string extra = Console.ReadLine();
        double price = 0; 
        double priceExtra = 0;

        if (drink == "coffee")
        {
             price = 1.00;

            if (extra == "sugar")
            {
                 priceExtra = 0.40;
            }
            else if (extra == "no")
            {
                 priceExtra = 0.00;
            }
        }
        else if (drink == "tea")
        {
             price = 0.60;
            if (extra == "sugar")
            {
                 priceExtra = 0.40;
            }
            else if (extra == "no")
            {
                 priceExtra = 0.00;
            }
        }
        double sum = price + priceExtra;


        Console.WriteLine($"Final price: ${sum:F2}");

    }
}

