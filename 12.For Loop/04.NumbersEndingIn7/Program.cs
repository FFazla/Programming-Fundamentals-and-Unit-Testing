namespace _04.NumbersEndingIn7;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for ( int i = 0; i <= number; i++)
        {
            if ( i % 10 == 7)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}

