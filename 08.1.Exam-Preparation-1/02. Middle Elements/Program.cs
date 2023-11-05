//Read an array of integers

//int[] inputArray = Console.ReadLine()
//        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//        .Select(int.Parse)
//        .ToArray();

string[] rawArray = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
double[] inputArray = new double[rawArray.Length];
for (int i = 0; i < rawArray.Length; i += 1)
{
    inputArray[i] = double.Parse(rawArray[i]);
}

//Find the middle numbers


int middleRightElementIndex = inputArray.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;
double middleElementsAverage = (inputArray[middleRightElementIndex] + inputArray[middleLeftElementIndex]) / 2;

Console.WriteLine($"{middleElementsAverage:F2}");