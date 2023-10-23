namespace _05.DivisionTo2_3and4;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int totalNumbers = 0;
        int divisibleBy2 = 0;
        int divisibleBy3 = 0;
        int divisibleBy4 = 0;
        int i = 0;

        while ( i < n)
        {
            
            int Num = int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
            {
                divisibleBy2++;
            }
            if (Num % 3 == 0)
            {
                divisibleBy3++;
            }
            if (Num % 4 == 0)
            {
                divisibleBy4++;
            }
            
            i++;
            totalNumbers++;


        }
        double percentageDivisibleBy2 = ((double)divisibleBy2 / totalNumbers) * 100;
        double percentageDivisibleBy3 = ((double)divisibleBy3 / totalNumbers) * 100;
        double percentageDivisibleBy4 = ((double)divisibleBy4 / totalNumbers) * 100;

        Console.WriteLine($"{percentageDivisibleBy2:F2}%");
        Console.WriteLine($"{percentageDivisibleBy3:F2}%");
        Console.WriteLine($"{percentageDivisibleBy4:F2}%");



    }
}

