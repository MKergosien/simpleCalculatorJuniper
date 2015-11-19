using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public string Number1;
        public string Number2; 
        public string Operator;
        private string expression;
        public Parse(string expressionParameter)
        {
            // store the expression
            expression = expressionParameter;
            
            // find the position of the plus sign
            int plusSignPosition = expression.IndexOf('+');

            // everything to the left is the first number
            Number1 = expression.Substring(0, plusSignPosition);

            // store the operator, which is one character long
            Operator = expression.Substring(plusSignPosition, 1);

            // the second number starts one character after the operator
            int number2Start = plusSignPosition + 1;

            // how long is the second number
            int number2Length = expression.Length - number2Start;

            // everything from after the plus sign to the end is the second number
            Number2 = expression.Substring(number2Start, number2Length);
        }
    }
}
