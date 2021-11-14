using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovayafor
{
    class Complex
    {
        public double g, e;
        public Complex Sum(Complex a, Complex b)
        {
            Complex complex = new Complex();
            complex.g = a.g + b.g;
            complex.e = a.e + b.e;
            return complex;
        }

        public Complex Multiplication(Complex a, Complex b)
        {
            Complex complex = new Complex();
            complex.g = a.g * b.g;
            complex.e = a.e * b.e;
            return complex;
        }

        public Complex Subtract(Complex a, Complex b)
        {
            Complex complex = new Complex();
            complex.g = a.g - b.g;
            complex.e = a.e - b.e;
            return complex;
        }

        public void Print(Complex a)
        {
            Console.Write("{0} + i{1}", a.g, a.e);
        }

        public void PrintLine(Complex a)
        {
            Console.WriteLine("{0} + i{1}", a.g, a.e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("первое комплексное число: ");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.Write("первая мнимая: ");
            double two = Convert.ToDouble(Console.ReadLine());
            Console.Write("второе комплексное число: ");
            double three = Convert.ToDouble(Console.ReadLine());
            Console.Write("вторая мнимая: ");
            double four = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Complex qwer = new Complex();
            Complex rewq = new Complex();
            qwer.g = one;
            qwer.e = two;
            rewq.g = three;
            rewq.e = four;
            Console.WriteLine("введенные комплексные числа: ");
            qwer.PrintLine(qwer);
            rewq.PrintLine(rewq);
            Console.WriteLine("сложение комплексных чисел:       {0} + {1}i", qwer.Sum(qwer, rewq).g, qwer.Sum(qwer, rewq).e);
            Console.WriteLine("умножение комплексных чисел:      {0} + {1}i", qwer.Multiplication(qwer, rewq).g, qwer.Multiplication(qwer, rewq).e);
            Console.WriteLine("вычитание комплексных чисел:      {0} + {1}i", qwer.Subtract(qwer, rewq).g, qwer.Subtract(qwer, rewq).e);
            Console.ReadLine();
        }
    }
}