int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

var commonElements = arr1.Intersect(arr2);

if (commonElements.Any())
{
    Console.WriteLine(string.Join(" ", commonElements));
}
else
{
    Console.WriteLine("null");
}