using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddWordProblem
{
    public class ReverseEveryOddWord
    {
        public string Reverse(string OriginalString)
        {
            var ReversedString = ""; 
            foreach (char ch in OriginalString)
            {
                ReversedString = ch + ReversedString; 
            }
            return ReversedString; 
        }
    }
}
