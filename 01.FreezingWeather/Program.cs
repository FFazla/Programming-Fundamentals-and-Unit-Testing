﻿namespace _01.FreezingWeather;
class Program
{
    static void Main(string[] args)
    {
        double temp = double.Parse(Console.ReadLine());
        if( temp <= 0)
        {
            Console.WriteLine("Freezing weather!");
        }
    }
}

