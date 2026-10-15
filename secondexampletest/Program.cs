using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondexampletest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for And operator
            //    true && false = false
            //    true && true = true
            //    false && false = false
            //    true && true = true

            //    for OR Operator
            //        true || false = true
            //        true || true = true
            //        false || false = false
            //        true || true = true

            //        for NOT operator
            //            !true = false
            //            !false = true

            bool c = true, d = false, result;

            //logical AND operator
            result = c && d;
            Console.WriteLine("AND operator: " + result);
            //logical OR Operator
            result = c || d;
            Console.WriteLine("OR operator: " + result);
            //logical NOT operator
            result = !c;
            Console.WriteLine("NOT operator: " + result);
            Console.ReadLine();
        }
    }
}
