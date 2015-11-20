using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public int Product;
        public Evaluate(Parse parser)
        {
            if (parser.Operator == "+")
            {
               Product = parser.Number1 + parser.Number2;
            }
            if (parser.Operator == "-")
            {
               Product = parser.Number1 - parser.Number2;
            }
            if (parser.Operator == "*" || parser.Operator == "x")
            {
                Product = parser.Number1 * parser.Number2;
            }
            if (parser.Operator == "/")
            {
                Product = parser.Number1 / parser.Number2;
            }

        }
    }
}
