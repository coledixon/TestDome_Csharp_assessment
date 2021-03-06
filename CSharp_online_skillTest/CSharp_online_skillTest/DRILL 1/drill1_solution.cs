﻿// SOLUTION // CD 2020
// PASSED 3 of 4 test cases (failed on unique names array)
using System;
using System.Collections.Generic;

namespace CSharp_online_skillTest.DRILL_1
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            List<string> result = new List<string>();

            foreach (string n1 in names1)
            {
                result.Add(n1);
            }
            foreach (string n2 in names2)
            {
                if (!result.Contains(n2))
                {
                    result.Add(n2);
                }
            }
            return result.ToArray();
        }

        // CD: moved fuctionality to Program.cs
        //public static void Main(string[] args)
        //{
        //    string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        //    string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        //    Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        //}
    }
}