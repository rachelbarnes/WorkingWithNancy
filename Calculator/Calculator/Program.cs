using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculate
    {
        public string[] SplitExpression(string x)
        {
            string[] splitExpression = x.Split(' ');
            return splitExpression;
        }
        public int EvaluateExpression(string expression)
        {
            //string[] operators = new string[] { "*", "/", "+", "-"}; 
            var split = SplitExpression(expression);
            var CalculatedInt = 0;
            for (var i = 0; i < split.Length; i++)
            {
                if (split[i] == "*")
                {
                    if (i == 1)
                    {
                        CalculatedInt = int.Parse(split[i - 1]) * int.Parse(split[i + 1]);
                    }
                    else
                    {
                        CalculatedInt *= int.Parse(split[i + 1]);
                    }
                }
                if (split[i] == ("/"))
                {
                    if (i == 1)
                    {
                        CalculatedInt = int.Parse(split[i - 1]) / int.Parse(split[i + 1]);
                    }
                    else
                    {
                        CalculatedInt /= int.Parse(split[i + 1]);
                    }
                }
                if (split[i] == ("+"))
                {
                    if (i == 1)
                    {
                        CalculatedInt = int.Parse(split[i - 1]) + int.Parse(split[i + 1]);
                    }
                    else
                    {
                        CalculatedInt += int.Parse(split[i + 1]);
                    }
                }
                if (split[i] == ("-"))
                {
                    if (i == 1)
                    {
                        CalculatedInt = int.Parse(split[i - 1]) - int.Parse(split[i + 1]);
                    }
                    else
                    {
                        CalculatedInt -= int.Parse(split[i + 1]);
                    }
                }
            }
                return CalculatedInt;
        }
    }
}
             