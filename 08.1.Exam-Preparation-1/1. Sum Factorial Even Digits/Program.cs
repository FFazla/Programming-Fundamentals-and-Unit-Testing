﻿// Read a number from the console and analyse digits
//Calculate Facturial
int result = int.Parse(Console.ReadLine());
int totalResult = 0;
while (result != 0)
{
    int digit = result % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorial(digit);
        totalResult += resultFactorial;
    }
        result = result / 10;
    
}
Console.WriteLine(totalResult);
//int result = CalculateFactorial(4);
//Console.WriteLine(result);

static int CalculateFactorial( int number )
{
    int result = 1;

    while(number > 0 )
    {
        result = result * number;
        number -= 1;
    }

    return result;

}

