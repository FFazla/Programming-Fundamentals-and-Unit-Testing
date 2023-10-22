namespace _04.FoodOrDrink;
class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();

        if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
        {
            Console.WriteLine("food");
        }
        else if ( product == "tea" || product == "water" || product == "coffee" || product == "juice")
        {
            Console.WriteLine("drink");
        }
        else
        {
            Console.WriteLine("unknown");
        }

     /*
            string product = Console.ReadLine();
            bool isFood = false;
            bool isDrink = false;

            if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
            {
                isFood = true;
            }
            else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
            {
                isDrink = true;
            }

            if (isFood)
            {
                Console.WriteLine("food");
            }
            else if (isDrink)
            {
                Console.WriteLine("drink");
            }
            else
            {
                Console.WriteLine("unknown");
            }
   
    */
    }
}



