using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

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

        // We have three sets of test so were going to use a generator array.
        // Firstly we mention the variables double and multiple since its the variables we have on test that is in common
        // We create a loop to calculate the multiples using "For" value.
        // We calculate multiples by using this formula Multiples = O'numbers' * (n'i' + 1)

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // Return multiples to array.
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

        // We have four set of test that is requested to rotate the list to the right so were going to use a transformer.
        // Firstly we use the variables List<int>number which is in the test.
        // Second is we create a loop to calculate to rotate the list to the right
        // Lastly we calculate it using getrange to pick up the number to move them, 
        // removerange to remove them form the list, 
        // and insertrange to insert them to the desired position. 

        var temp = data.GetRange(data.Count - amount, amount);

        data.RemoveRange(data.Count - amount, amount);
        
        data.InsertRange(0, temp);
    }
}
