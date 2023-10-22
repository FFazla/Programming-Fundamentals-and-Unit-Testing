namespace _06.ProductofThreeNumbers;
class Program
{
    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double result = 0;

        if (num1 * num2 * num3 < 0)
        {
            Console.WriteLine("negative");
        }
        else if (num1 * num2 * num3 == 0)
        {
            Console.WriteLine("zero");
        }
        else if (num1 * num2 * num3 > 0)
        {
            Console.WriteLine("positive");
        }


        /*
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

        
        bool isPositive = (number1 >= 0 && number2 >= 0 && number3 >=0)||
                          (number1 < 0 && number2 < 0 && number3 >= 0) ||
                          (number1 < 0 && number2 >= 0 && number3 < 0) ||
                          (number1 >= 0 && number2 < 0 && number3 < 0);

        
        if (isPositive && (number1 != 0 && number2 != 0 && number3 != 0))
        {
            Console.WriteLine("positive");
        }
        else if (number1 == 0 || number2 == 0 || number3 == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("negative");
        }
         */
    }
}

