﻿namespace _01.Marketplace;
class Program
{
    static void Main(string[] args)
    {

        /*
           string product = Console.ReadLine();
           string day = Console.ReadLine();
           double price = 0;
           if (product == "Banana")
           {
               if(day == "Weekday")
               {
                   price = 2.50;
               }
               else if ( day == "Weekend")
               {
                   price = 2.70;
               }

           }
           else if (product == "Apple")
           {
               if(day == "Weekday")
               {
                   price = 1.30;
               }
               else if ( day == "Weekend")
               {
                   price = 1.60;
               }

           }
           else if (product == "Kiwi")
           {
               if(day == "Weekday")
               {
                   price = 2.20;
               }
               else if ( day == "Weekend")
               {
                   price = 3.00;
               }

           }
              Console.WriteLine($"{price:F2}");

        }
         */
        string product = Console.ReadLine();
        string day = Console.ReadLine();
        
        if (product == "Banana")
        {
            if(day == "Weekday")
            {
                Console.WriteLine("2.50");
            }
            else if (day == "Weekend")
            {
                Console.WriteLine("2.70");

            }
        }
        else if (product == "Apple")
        {
            if (day == "Weekday")
            {
                Console.WriteLine("1.30");

            }
            else if (day == "Weekend")
            {
                Console.WriteLine("1.60");
            }

        }
        else if (product == "Kiwi")
        {
            if(day == "Weekday")
            {
                Console.WriteLine("2.20");
            }
            else if (day == "Weekend")
            {
                Console.WriteLine("3.00");

            }
        }
        
    }
}

