using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.Utilities;

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

        // A new array will be created to hold the collection of multiples while we will be using a for loop to get and will be returned at the end of this method

        // step.1 Creating of the new array to hold the multiple
        double[] multiple = new double[length];
        // step.2 a for loop to find the multiples
        for (int i=0;i < length ; i++)
        {
            multiple[i] = number * (i + 1);
        }
        // step.3 returning array
        return multiple; // replace this return statement with your own
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

        // A for loop will be created and the number of iteration will be the amount parameter in the method 
        // and the last element will be added back to the list's index zero and will be removed from the last index
         
        // step.1 creating the for loop for the amount iterations
        for(int i = 1;i <= amount;i++)
        {
            // step.2 adding the last element to the list at index 0 and removing it from the last index
            data.Insert(0,data[data.Count() - 1]);
            data.RemoveAt(data.Count() - 1);
        }

    }
}
