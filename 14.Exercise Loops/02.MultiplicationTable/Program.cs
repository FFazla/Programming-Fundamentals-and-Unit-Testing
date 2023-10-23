namespace _02.MultiplicationTable;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        
        while(i <= 10)
        {
           int  result = n * i;
            Console.WriteLine($"{n} x {i} = {result}");
            i++;
        }

        /* for(int i = 1; i <= 10; i++)
      {
          result = n * i;
          Console.WriteLine($"{n} x {i} = {result}");
      }*/

    }
}

