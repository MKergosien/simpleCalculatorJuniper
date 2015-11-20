using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public int Number1;
        public int Number2; 
        public string Operator;
        private string expression;
        public Parse(string expressionParameter)
        {
            // store the expression and remove spaces
            expression = expressionParameter.Replace(" ", string.Empty).ToLower();
            
            // find the position of the operator
            int operatorIndex = expression.IndexOfAny(new char[] { '+', '-', '%', '/', '*', '=' , 'x' });

            // everything to the left is the first number
            Number1 = Convert.ToInt32(expression.Substring(0, operatorIndex ));

            // store the operator, which is one character long
            Operator = expression.Substring(operatorIndex, 1);

            // the second number starts one character after the operator
            int number2Start = operatorIndex + 1;

            // how long is the second number
            int number2Length = expression.Length - number2Start;

            // everything from after the operator to the end is the second number
            Number2 = Convert.ToInt32(expression.Substring(number2Start, number2Length));
        }
    }

    
}
