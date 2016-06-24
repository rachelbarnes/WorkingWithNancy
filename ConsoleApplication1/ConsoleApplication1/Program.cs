using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pal = new TestingPalindromes();
            Console.WriteLine(pal.PalindromeOrNo("hippo"));
            Console.ReadLine(); 
        }
    }
    public class TestingPalindromes
    {
        public bool PalindromeOrNo(string testString)
        {
            var reversedString = testString.Reverse().ToString();  
            if (reversedString == testString)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
