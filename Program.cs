using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("III");
        }


        public static void RomanToInt(string s)
        {
            string[] sArray = s.Split("");
            Console.WriteLine(sArray);

        }
    }
}
      
