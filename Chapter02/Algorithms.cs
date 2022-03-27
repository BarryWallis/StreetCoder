using System.Diagnostics;

namespace Chapter02;
public static class Algorithms
{
    /// <summary>
    /// Determine if an array contains a specific element.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <param name="lookFor">The element.</param>
    /// <returns>True if the element is in the array; otherwise false.</returns>
    public static bool Contains(int[] array, int lookFor)
    {
        bool result = false;
        for (int n = 0; n < array.Length; n++)
        {
            if (array[n] == lookFor)
            {
                result = true;
                break;
            }
        }

        return result;
    }

    /// <summary>
    /// Determine if an array contains a specific positive element. 
    /// </summary>
    /// <param name="array">The array.</param>
    /// <param name="lookFor">The element.</param>
    /// <returns>True if the element is in the array; otherwise false.</returns>
    public static bool ContainsPositive(int[] array, int lookFor)
    {
        bool result = false;
        if (lookFor > 0)
        {
            result = Contains(array, lookFor);
        }

        return result;
    }

    /// <summary>
    /// Determine if an array contains a specific positive element. 
    /// </summary>
    /// <param name="array">The array.</param>
    /// <param name="lookFor">The element.</param>
    /// <returns>True if the element is in the array; otherwise false.</returns>
    public static bool ContainsUnsigned(uint[] array, uint lookFor)
    {
        bool result = false;
        for (int n = 0; n < array.Length; n++)
        {
            if (array[n] == lookFor)
            {
                result = true;
                break;
            }
        }

        return result;
    }


    /// <summary>
    /// Determine if a sorted array contains a specific positive element. 
    /// </summary>
    /// <param name="array">The array.</param>
    /// <param name="lookFor">The element.</param>
    /// <returns>True if the element is in the array; otherwise false.</returns>
    public static bool ContainsSorted(uint[] array, uint lookFor)
    {
        Debug.Assert(array.OrderBy(u => u).SequenceEqual(array));

        bool result = false;
        int start = 0;
        int end = array.Length - 1;
        while (start <= end)
        {
            int middle = start + ((end - start) / 2);
            uint value = array[middle];
            if (lookFor == value)
            {
                result = true;
                break;
            }
            else if (lookFor > value)
            {
                start = middle + 1;
            }
            else
            {
                end = middle - 1;
            }
        }

        return result;
    }

}
