string drink = Console.ReadLine();
string extra = Console.ReadLine();
double coffee = 1.00;
double tea = 0.60;
double sugar = 0.40;
double no = 0;
double totalPrice = 0;
bool orderValid = true;



if (drink == "coffee")
{
    if (extra == "sugar")
    {
        totalPrice = coffee + sugar;

    }
    else if (extra == "no")
    {
        totalPrice = coffee + no;

    }
    else
    {
        Console.WriteLine("Unknown extra");
        orderValid = false;
    }

}
else if (drink == "tea")
{
    if (extra == "sugar")
    {
        totalPrice = tea + sugar;

    }
    else if (extra == "no")
    {
        totalPrice = tea + no;

    }
    else
    {
        Console.WriteLine("Unknown extra");
        orderValid = false;
    }
}
else
{
    Console.WriteLine("Unknown drink");
    orderValid = false;
}
if (orderValid)
{

    Console.WriteLine($"Final price: ${totalPrice:F2}");
}

