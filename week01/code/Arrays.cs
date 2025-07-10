using System.Diagnostics; // For debugging, if needed

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan for MultiplesOf:
        // 1. Accept number (double) and length (int) as inputs.
        // 2. Create a new double array of size length.
        // 3. Iterate through indices 0 to length-1.
        // 4. For each index i, calculate the multiple as number * (i + 1).
        // 5. Store each multiple in the array at index i.
        // 6. Return the completed array.
        
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    /// 
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan for RotateListRight:
        // 1. Accept data (List<int>) and amount (int) as inputs.
        // 2. If the list is empty or amount is 0, return early.
        // 3. Use list slicing to:
        //    a. Extract the last 'amount' elements (from index data.Count - amount).
        //    b. Extract the first 'data.Count - amount' elements (from index 0).
        // 4. Clear the original list.
        // 5. Add the last part followed by the first part to achieve rotation.
        // 6. Modify the original list in place.
        
        if (data.Count == 0 || amount == 0)
            return;

        // Extract the two parts using GetRange
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Clear the original list
        data.Clear();

        // Add parts in rotated order
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}