namespace Implementations;

public class BinarySearchAlgorithm
{
     /// <summary>
     /// Implementation of the binary search algorithm
     /// </summary>
     /// <param name="array">Sorted list of items</param>
     /// <param name="item">Item to search for</param>
     /// <typeparam name="T">Item that implements IComparable</typeparam>
     /// <returns>Item if found or null</returns>
     public static T BinarySearch<T>(IEnumerable<T> array, T item) where T: IComparable
     {

          var collection = array.ToArray();
          
          var low = 0;
          var high = collection.Length - 1;
          

          while (low <= high)
          {
               var mid = (low + high) / 2;
               var foundItem = collection[mid];

               switch (foundItem.CompareTo(item))
               {
                    case 0:
                         return foundItem;
                    // If found item is larger than search item
                    case > 0:
                         // Minus 1 because you don't need to check value at mid point again
                         high = mid -1;
                         break;
                    // Plus 1 because you don't need to check value at mid point again
                    case < 0:
                         low = mid + 1;
                         break;
               }
          }
          return default;
     }
}