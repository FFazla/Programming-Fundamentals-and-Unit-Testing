namespace _9.AreaOfFigures;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        if (type == "square")
        {
            double n = double.Parse(Console.ReadLine());
            double area = Math.Pow(n, 2);
            Console.WriteLine($"{area:F2}");
        } else if (type == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine($"{area:F2}");
        } else if (type == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{area:F2}");
        }
        else
        {
            Console.WriteLine("Invalid figure.");
        }
        

    }
}

