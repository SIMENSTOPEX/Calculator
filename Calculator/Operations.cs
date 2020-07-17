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
        public double vichitanie(double a, double b)
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
        public double sinus(double a)
        {
            return Math.Sin(a);
        }
        public double cosinus(double a)
        {
            return Math.Cos(a);
        }
    }
}