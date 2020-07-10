using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations:Interface
    {
        public double summa (double a, double b)
        {
            return a + b;
        }
        public double vuchitanue(double a, double b)
        {
            return a - b;
        }
        public double umnoszenie(double a, double b)
        {
            return a * b;
        }
        public double delenie(double a, double b)
        {
            return a / b;
        }

    }
}