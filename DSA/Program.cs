// See https://aka.ms/new-console-template for more information
using Implementations;

void BinarySearch()
{
    int[] myNums= {1,2,4,5,6,7, 100, 2000};
    var result = BinarySearchAlgorithm.BinarySearch(myNums, 2000);
    Console.WriteLine(result);
}

void SelectionSort()
{
    int[] myNums = {3, 1 ,200 ,17 ,9 , 33 , 4 , 9};
    SelectionSortAlgorithm.SelectionSort(myNums);
    foreach (var item in myNums)
    {
        Console.WriteLine(item);
    }
}

void BeginnerRecursion()
{
    // Factorial
    Console.WriteLine(Recursion.Factorial(3));
    // Sum
    Console.WriteLine(Recursion.Sum(new int[]{5,5}));
    // Length
    Console.WriteLine(Recursion.Length(new int[]{5,5,5,6,7,8}));
    // Max
    Console.WriteLine(Recursion.Max(new int[]{5,1,2,6,40,2,8}));
    // Recursive Binary Search
    Console.WriteLine(Recursion.BinarySearch(new []{1,2,4,5,6,7,8, 100, 2000}, 3));
    // Farmers Box Plot
    Console.WriteLine(Recursion.Euclidian(1200, 87));
}

BeginnerRecursion();

