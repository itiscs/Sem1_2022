using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    public class Equation2:Equation1  //ax^2 + bx + c = 0
    {
        protected double _a;
        protected double _x2;

        public Equation2(double a, double b, double c):base(b,c)
        {
            _a = a;
        }
        public override void Solve()
        {
            if (_a == 0)
                base.Solve();
            else
            {
                var disr = _b * _b - 4 * _a * _c;
                if (disr < 0)
                    countRes = 0;
                else
                {
                    countRes = 2;
                    _x1 = (-_b + Math.Sqrt(disr)) / (2 * _a);
                    _x2 = (-_b - Math.Sqrt(disr)) / (2 * _a);
                }
            }

        }

        public void PrintResult()
        {
            if(countRes == 0)
            {
                Console.WriteLine("Решений в вещественных числах нет");
            }
            else if(countRes == 2) 
            {
                Console.WriteLine($"x1 = {_x1}    x2 = {_x2}");
            }
            else
                base.PrintResult();
        }

        public override string ToString()
        {
            return $"{_a}x^2 + {_b}x + {_c} = 0";
        }

    }
}
