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
        // First I make a new array with the size that was given by length.
        // Then I go through every position in the array with a for loop.
        // Because array indexes start at 0, I use i + 1 to get the correct multiple.
        // Each result is saved in the array.
        // At the end I return the finished array.

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
        // First I find the place where the last part of the list starts.
        // The last part is the amount of numbers that need to move to the front.
        // Then I save the last part in a new temporary list.
        // I also save the first part of the list in another temporary list.
        // After that I clear the original list.
        // Then I add the last part first, because it should now be at the front.
        // Finally I add the first part after it.

        int splitIndex = data.Count - amount;

        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}