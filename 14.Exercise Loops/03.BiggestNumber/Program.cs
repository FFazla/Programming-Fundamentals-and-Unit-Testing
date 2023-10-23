namespace _03.BiggestNumber;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        int maxNum = int.MinValue;
        while (i < n)
        {
            int cNum = int.Parse(Console.ReadLine());
            if (cNum > maxNum)
            {
                maxNum = cNum;
            }
            i++;

        }
        Console.WriteLine(maxNum);

    }

    /*
     {
        int n = int.Parse(Console.ReadLine());
        int maxNum = int.MinValue;
        for (int i = 0 ; i < n; i++)
        {
            int cNum = int.Parse(Console.ReadLine());
            
            if(cNum > maxNum)
            {
                maxNum = cNum;
                
            }
        }
        Console.WriteLine(maxNum);
        
        
        
       
    }
    */
}

