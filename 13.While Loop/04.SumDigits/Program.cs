namespace _04.SumDigits;
class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        int rest;
        while( num > 0)
        {
            rest = num % 10;
            sum += rest;
            num /= 10;

        }
        Console.WriteLine(sum);
    }
}

