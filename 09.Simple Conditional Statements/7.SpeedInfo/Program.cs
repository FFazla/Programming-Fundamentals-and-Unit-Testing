namespace _7.SpeedInfo;
class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        if (n <= 30)
        {
            Console.WriteLine("slow");
        }
        else
        {
            Console.WriteLine("fast");
        }

    }
}

