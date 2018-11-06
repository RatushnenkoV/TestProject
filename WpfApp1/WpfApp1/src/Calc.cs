using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Calc
    {
        public double a;
        public double b;

        double Add()
        {
            return a + b;
        }

        double Sub()
        {
            return a - b;
        }

        double Div()
        {
            return a / b;
        }

        double Mult()
        {
            return a * b;
        }
    }
}
