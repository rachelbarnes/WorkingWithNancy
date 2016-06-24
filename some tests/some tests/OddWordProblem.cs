using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace some_tests
{
    //the odd word problem: set of characters that form a sentence ending with a '.'. reverse the oddwords, which either can  or don't have to start with 0 based indexing. The characters can only be read and printed one at a time. 
    public class OddWordProblem
    {
        public string Reverse(string originalString)
        {
            var reversedString = ""; 
            foreach (var character in originalString)
            {
                reversedString = character + reversedString; 
            }
            return reversedString; 
        }
    }
}
