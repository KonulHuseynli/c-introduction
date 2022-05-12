using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 12, 7, 19, 36, 40, 58, 65, 87, 27, 23 };
            Console.Write("Yasinizi daxil edin: ");
            string yash = Console.ReadLine();
            int Age = Int32.Parse(yash);
            bool result = false;
            foreach (int item in Array)
            {
                if (Age == item)
                {
                    result = true;
                }
            }
            Console.WriteLine(result);
        }
    }
}

