namespace Implementations;
using System.Linq;

public class Recursion
{
    // Classic recursive method
    public static long Factorial(long x)
    {
        // if (x == 0)
        // {
        //     return 1;
        // }
        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    public static int Euclidian(int x = 1680, int y = 640)
    {
        // A 0 value indicates a residual of 0
        if (x == 0)
            return y;
        
        if (y == 0)
            return x;

        // Longest side of current shape
        var max = Math.Max(x, y);
        // Shortest side, aka length of biggest possible box/boxes
        var multiple = Math.Min(x, y);
        
        // Find amount of boxes you can fit in
        var nBoxes = (int)Math.Floor(max / (decimal)multiple);
        
        // Get leftover space, if 0, largest size has been found
        var leftover = max - (multiple * nBoxes);
        
        return Euclidian(leftover, multiple);
            
            // if (x > y)
            // {
            //     x = leftover;
            // }
            // else y = leftover;
            //
            // return Euclidian(x, y);
            
            // // Find biggest box you can put in it
            // int nBoxes = 0;
            // // Longest side of current shape
            // var residual = Math.Max(x, y);
            // // Shortest side, aka length of biggest possible box/boxes
            // var multiple = Math.Min(x, y);
            // while (residual >= 0)
            // {
            //     if (residual - multiple > 0)
            //     {
            //         nBoxes++;
            //     }
            //
            //     residual -= multiple;
            // }
        

    }

    public static int Sum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        else
        {
            return nums[0] + Sum(nums.Skip(1).ToArray());
        }
    }

    public static int Length(int[] nums)
    {
        // Try Catch acts as the base case
        try
        {
            var num = nums[0];
        }
        catch (IndexOutOfRangeException e)
        {
            return 0;
        }

        return 1 + Length(nums.Skip(1).ToArray());
    }

    public static int Max(int[] nums, int max = 0)
    {
        if (nums.Length == 0)
        {
            return max;
        }
        else
        {
            max = nums[0] > max ? nums[0] : max;
            return Max(nums.Skip(1).ToArray(), max);
        }
    }

    public static int BinarySearch(int[] nums, int searchTerm)
    {
        // Base Case
        if (nums.Length == 1)
        {
            return nums[0] == searchTerm ? searchTerm : -1;
        }
        
        var mid = (nums.Length + 1) / 2;
        
        if (searchTerm == nums[mid])
        {
            return nums[mid];
        }
        
        if (searchTerm > nums[mid])
        {
            var lowerBound = mid + 1;
            return BinarySearch(nums[lowerBound .. nums.Length], searchTerm);
        }
        
        var upperBound = mid - 1;
        return BinarySearch(nums[0..upperBound], searchTerm);
    }
}