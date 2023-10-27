int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for(int currentNum=start; currentNum <= end; currentNum += 1)
{
    bool isPrime = true;
    int divider = 2;

    while (divider < end)
    {
        if (currentNum == divider)
        {
            divider += 1;
            continue; 

        }
        if (currentNum % divider == 0)
        {
            isPrime = false;
            break;

        }

        divider += 1;
    }
    if (isPrime)
    {
        Console.Write($"{currentNum} ");
    }
}

