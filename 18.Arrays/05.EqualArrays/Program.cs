int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for(int index = 0; index <= arr1.Length - 1; index++)
{
    if (arr1[index] != arr2[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
    
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
