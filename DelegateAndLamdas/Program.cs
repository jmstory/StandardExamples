using System;
using System.Linq;
using System.Collections.Generic;
namespace DelegateAndLamdas
{
    class Program
    {
        public delegate string Reverse(string s);

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            Reverse rev = ReverseString;
            Console.WriteLine(rev("a string"));

            Func<string,string> rev1 = ReverseString;
            Console.WriteLine(rev1("a string"));

            List<int>list = new List<int>();

            for(int i = 1 ; i <= 100 ; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll( delegate (int no){return (no %2 == 0);});
            foreach(var item in result)            
            {
                Console.WriteLine(item);
            }
        }
    }
}
