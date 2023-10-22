namespace _06.ExamCountdown;
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        for ( int i = days; i <= days; i--)
        {
            Console.WriteLine($"{i} days before the exam");
            if( i == 1)
            {
                Console.WriteLine("The exam has come");
                break;

            }
        }
    }
}

