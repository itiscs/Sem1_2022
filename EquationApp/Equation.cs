using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    public abstract class Equation
    {
        protected int countRes;

        public virtual void Solve()
        {
            Console.WriteLine("Решаем уравнение!");
        }
        public abstract void PrintResult();

        public static Equation CreateEq(params int[] coefs)
        {
            if(coefs.Length == 1)
            {
                return new Equation0(coefs[0]);
            }
            if (coefs.Length == 2)
            {
                return new Equation1(coefs[0], coefs[1]);
            }
            if (coefs.Length == 3)
            {
                return new Equation2(coefs[0], coefs[1], coefs[2]);
            }
            throw new ArgumentException("Неправильное количество аргументов");

        }
    }

}
