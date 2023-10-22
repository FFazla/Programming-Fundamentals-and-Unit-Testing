namespace _02.ATM;
class Program
{
    static void Main(string[] args)
    {
        int balance = int.Parse(Console.ReadLine());
        int withdraw = int.Parse(Console.ReadLine());
        int limit = int.Parse(Console.ReadLine());

        int operation = 0;

        if (balance > withdraw && limit > withdraw)
        {
            Console.WriteLine("The withdraw was successful.");
        }
        else if (limit < withdraw)
        {
            Console.WriteLine("The limit was exceeded.");

        }
        else if (balance < withdraw)
        {
            Console.WriteLine("Insufficient availability.");
        }
    }
}

