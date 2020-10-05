using ConsoleApp2.SpecialExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculator
    {
        public Calculator()
        {
        }

        public int Add(string a1, string a2)
        {
            int result = 0;
            bool validated = false;

            int.TryParse(a1, out int n1);
            int.TryParse(a2, out int n2);

            validated = validateArguments(n1, n2);

            if (!validated)
            {
                result = n1 + n2;
            }

            return result;
        }

        private bool validateArguments(int n1, int n2)
        {
            if (n1 == 0 || n2 == 0)
            {
                throw new IsZeroException("One input is zero");
            }

            return false;
        }
    }
}
