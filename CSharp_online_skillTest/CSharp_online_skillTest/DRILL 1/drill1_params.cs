// DRILL PARAMETERS (4 test cases)

/*
 Implement the UNIQUENAMES method. 
 When passed 2 arrays of names, it will return an array containing the namthat sppear in EITHER or BOTH arrays.
 The returned array should have no duplicates.
 */


// BASE CODE PROVIDED
using System;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}