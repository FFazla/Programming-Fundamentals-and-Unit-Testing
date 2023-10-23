namespace _06.SpecialNumber;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int startNumber = number;
        bool isSpecial = true;
        while (number > 0)
        {
            int lastDigit = number % 10;
            if (startNumber % lastDigit != 0)
            {
                isSpecial = false;
                break;

            }
            else
            {
                number = number / 10;
            }
                
        }
        if (isSpecial == true)
        {
            Console.WriteLine($"{startNumber} is special");
        }
        else
        {
            Console.WriteLine($"{number} is not special");
        }
    }
}

