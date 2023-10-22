namespace _05.VacationExpenses;
class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        string accommodation = Console.ReadLine();
        int countDays = int.Parse(Console.ReadLine());
        double price = 0;
        
        if (season == "Spring") 
        {
            if( accommodation == "Hotel")
            {
                price =(30 * countDays) - (30 * 0.2 * countDays);
            }
            else if ( accommodation == "Camping")
            {
                price = (10 * countDays) - (10 * 0.2 * countDays);
            }
        }
        else  if (season == "Summer")
        {
            if (accommodation == "Hotel")
            {
                price = 50 * countDays ;
            }
            else if (accommodation == "Camping")
            {
                price = 30 * countDays;
            }
        }
        else if (season == "Autumn")
        {
            if (accommodation == "Hotel")
            {
                price = (20 * countDays) - (20 * 0.3 * countDays);
            }
            else if (accommodation == "Camping")
            {
                price = (15 * countDays) - (15 * 0.3 * countDays);
            }
        }
        else if (season == "Winter")
        {
            if (accommodation == "Hotel")
            {
                price = (40 * countDays ) - (40 * 0.1 * countDays);
            }
            else if (accommodation == "Camping")
            {
                price = (10 * countDays) - (10 * 0.1 * countDays);
            }
        }

        Console.WriteLine($"{price:F2}");




    }
}
