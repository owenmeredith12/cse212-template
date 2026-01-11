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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //im going to create an array to store the output
        //then create a for loop that iterates through starting at 1 until the length
        //during each iteration i am going to multiply i * the number given then store the output in the
        // array from step 1

        double[] multiples = new double[length + 1];

        for (int i = 1; i <= length; i++)
        {
            double result = i * number;
            multiples[i] = result;
        }

        return multiples; 
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // im not sure if this is the optimal way to do this but im going to 
        //take the input array and split it at the number that is provided as the
        // shift amound and then store the right have in and array and the left half
        // in another array and then swap their places and then recombine them

        int count = data.Count;
        int splitIndex = count - amount;

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < splitIndex; i++)
        {
            left.Add(data[i]);
        }

        for (int i = splitIndex; i < count; i++)
        {
            right.Add(data[i]);
        }

        data.Clear();

        for (int i = 0; i < right.Count; i++)
        {
            data.Add(right[i]);
        }

        for (int i = 0; i < left.Count; i++)
        {
            data.Add(left[i]);
        }
        Console.WriteLine(string.Join(", ", data));
    }
}
