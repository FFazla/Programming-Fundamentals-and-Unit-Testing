namespace _03.SumNumbers;
class Program
{
    static void Main(string[] args)
    {
        int numberOfNumbers = int.Parse(Console.ReadLine());
        double sumNumbers = 0; 
        for (int i = 0; i < numberOfNumbers; i += 1)
        {
            double number = double.Parse(Console.ReadLine());
            sumNumbers = sumNumbers + number;

        }
        Console.WriteLine(sumNumbers);
    }
}

