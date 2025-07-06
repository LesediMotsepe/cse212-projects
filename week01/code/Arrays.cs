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
        // TODO Problem 1 Start
        //1. Create an array: Initialize an array of doubles with the specified length.
        //2. Calculate multiples: Iterate from 0 to length-1, calculating the multiple of the number for each index.
        //3. Store multiples: Store each multiple in the corresponding index of the array.
        //4. Return array: Return the array of multiples.
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Create an array to store the multiples
        double[] multiples = new double[length];
    


        // Calculate and store each multiple
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple by multiplying the number with the current index + 1
            multiples[i] = number * (i + 1);
        }

        // Return the array of multiples
        return multiples;


    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.


    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //1. Calculate effective rotation amount: Calculate the effective rotation amount by taking the modulus of the amount with the count of the list. This is to handle cases where the amount is greater than the count of the list.
        //2. Get the last 'amount' elements: Get the last 'amount' elements from the list.
        //3. Remove the last 'amount' elements: Remove the last 'amount' elements from the list.
        ///4. Insert the removed elements at the beginning: Insert the removed elements at the beginning of the list.
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Calculate effective rotation amount
        int effectiveAmount = amount % data.Count;

        // Get the last 'effectiveAmount' elements
        var lastElements = data.GetRange(data.Count - effectiveAmount, effectiveAmount);

        // Remove the last 'effectiveAmount' elements
        data.RemoveRange(data.Count - effectiveAmount, effectiveAmount);

        // Insert the removed elements at the beginning
        data.InsertRange(0, lastElements);
      



    }
    
}
