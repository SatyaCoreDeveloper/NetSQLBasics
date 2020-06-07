using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Calculator
    {

        public  int Max(int num1, int num2)
        {
            if ((num1 <= 0) || (num2 <= 0))
                return 0;
            if (num1 >= 5000 || num2 >= 5000)
                return 5000;
            return Max(num1, num2);

        }
    }
}
