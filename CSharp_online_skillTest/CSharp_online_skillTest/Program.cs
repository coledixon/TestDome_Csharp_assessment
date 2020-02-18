using CSharp_online_skillTest.DRILL_1;
using CSharp_online_skillTest.DRILL_2;
using CSharp_online_skillTest.DRILL_3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_online_skillTest
{
    public class drill_validation
    {
        public static void Main(string[] args)
        {
            int input;

            select_drill:
            Console.WriteLine("SELECT C# DRILL TO VALIDATE");
            Console.WriteLine("select a drill using 1, 2, or 3. || or type 0 to exit program");
            bool pass = int.TryParse(Console.ReadLine(), out input);

            if (!pass)
            {
                Console.WriteLine("please enter a numeric value");
                goto select_drill;
            }
            else
            {
                if (input == 0) { return; }
                else if (input > 3 || input < 0)
                {
                    Console.WriteLine("please limit your numeric entry to 1, 2, or 3");
                    goto select_drill;
                }
            }

            switch (input)
            {
                case 1:
                    Execute_Drill1();
                    break;
                case 2:
                    Execute_Drill2();
                    break;
                case 3:
                    Execute_Drill3();
                    break;
            }
        }

        public static void Execute_Drill1()
        {
            Console.WriteLine("DRILL 1 : unique name method");
            Console.WriteLine("---- press  enter to continue ----");
            Console.ReadKey();


            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            Console.ReadKey();

            Main(null);
        }

        public static void Execute_Drill2()
        {
            Console.WriteLine("DRILL 2 : interface / constructor");
            Console.WriteLine("this a strictly programming drill, no output for user to evaluate");
            Console.WriteLine("---- press enter to continue ----");
            Console.ReadKey();

            Main(null);
        }

        public static void Execute_Drill3()
        {
            bool _res;

            Console.WriteLine("DRILL 3 : anagram string compare");
            Console.WriteLine("---- press enter to continue ----");
            Console.ReadKey();
            // debug
            _res = AnagramEval.EvalAnagram("Bendy", "beNDs"); // false
            Console.WriteLine("evlauation 1 (bendy : bends) = "+_res);
            Console.ReadKey();
            _res = AnagramEval.EvalAnagram("angel", "angle"); // true
            Console.WriteLine("evlauation 2 (angel : angle) = " + _res);
            Console.ReadKey();
            _res = AnagramEval.EvalAnagram("listen", "silent"); // true
            Console.WriteLine("evlauation 3 = (listen : silent) " + _res);
            Console.ReadKey();

            Main(null);
        }
    }
}
