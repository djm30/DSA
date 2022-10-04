namespace Implementations;
using System.Linq;

public class SelectionSortAlgorithm
{
    /// <summary>
    /// Two partitions of array - Sorted part and Unsorted part
    /// For every index of the array, the rest of the array (unsorted partition) is looped through to
    /// to find the minimum value, which will then be swapped to the current index
    /// (Unless the current index is the current minimum)
    /// Outer loop loops to n-1 -> the index being the start of the unsorted portion of the array
    /// Inner loop loops to n -> finds the minimum value in the unsorted array
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    public static void SelectionSort<T>(IList<T> list) where T: IComparable
    {
        for (int i = 0; i < list.Count -1; i++)
        {
            var smallest = i;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j].CompareTo(list[smallest]) < 0)
                {
                    smallest = j;
                }
                // SWAP smallest and first index of array  
                
            }

            var temp = list[i];
            list[i] = list[smallest];
            list[smallest] = temp;
        }   
    }
}