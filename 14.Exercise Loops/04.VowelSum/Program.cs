namespace _04.VowelSum;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        int sum = 0;
        while (i < n)
        {
            char l = char.Parse(Console.ReadLine());
            if ( l == 'a')
            {
                sum += 1;
            }
            else if ( l == 'e')
            {
                sum += 2;

            }
            else if (l == 'i')
            {
                sum += 3;

            }
            else if (l == 'o')
            {
                sum += 4;

            }
            else if (l == 'u')
            {
                sum += 5;

            }
            i++;

        }
        Console.WriteLine(sum);
    }
}

