using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int n, int d)
        {
            if (d == 0)
                throw new ArgumentException("Нельзя делить на ноль!");

            numerator = n;
            denominator = d;
        }

        public Fraction(int n):this(n, 1)
        {
            //numerator = n;
            //denominator = 1;
        }
        public Fraction():this(0, 1)
        {
            //numerator = 0;
            //denominator = 1;
        }

        private void PrivMethod()
        {


        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }
        public void SetNum(int n) 
        {
            numerator = n;  
        }

        public int GetNum()
        {
            return numerator;
        }

        public void SetDenom(int d)
        {
            if (d == 0)
                throw new ArgumentException("Нельзя делить на ноль!");
            denominator = d;
        }

        public int GetDen()
        {
            return denominator;
        }

        public void Print()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }


        public void Sokr()
        {
            //ToDo
        }


        public void Add(Fraction f)
        {
            this.numerator = this.numerator * f.denominator +
                this.denominator * f.numerator;
            this.denominator = this.denominator * f.denominator;
            Sokr();
        }

        public void Add(Fraction f1, Fraction f2)
        {
            this.numerator = f1.numerator * f2.denominator +
                f1.denominator * f2.numerator;
            this.denominator = f1.denominator * f2.denominator;
            Sokr();
        }






    }
}
