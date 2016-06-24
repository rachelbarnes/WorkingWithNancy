using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace some_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverse = new OddWordProblem();
            var WriteThis = reverse.Reverse("parrot");
            Console.WriteLine(WriteThis);
            Console.ReadLine();
        }
    }
}
