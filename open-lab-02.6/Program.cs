using System;

namespace open_lab_02._6
{
    class Program
    {
        public static int Sum(int a)
        {
            return a % 100;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 100 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
