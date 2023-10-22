namespace _09.SumSeconds;
class Program
{
    static void Main(string[] args)
    {
        int athlete1 = int.Parse(Console.ReadLine());
        int athlete2 = int.Parse(Console.ReadLine());
        int athlete3 = int.Parse(Console.ReadLine());

        int totalTime = 0;

        totalTime = athlete1 + athlete2 + athlete3;

        int miutes = totalTime / 60;
        int seconds = totalTime % 60;

        Console.WriteLine($"{miutes}:{seconds:D2}");

    }
}

