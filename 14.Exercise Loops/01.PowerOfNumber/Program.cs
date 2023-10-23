namespace _01.PowerOfNumber;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int result = 1;
        int c = 0;
        while(c < p)
        {
            result *= n;
            c++;
            


        }
        Console.WriteLine(result);

        /*
         int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int sum = 1;
        for(int i = 1; i <= p ; i++)
        {
            sum = sum * n;
        }
        Console.WriteLine(sum);
         */
    }
}

