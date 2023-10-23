namespace _07.SpecialBonus;
class Program
{
    static void Main(string[] args)
    {
        int stopNum = int.Parse(Console.ReadLine());
        int prevNum = stopNum;

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == stopNum)
            {

                Console.WriteLine($"{prevNum * 1.2}");
                break;
            }
            else
            {
                prevNum = num;
            }
        }
    }
}

