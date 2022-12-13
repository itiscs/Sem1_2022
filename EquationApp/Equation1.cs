using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    public class Equation1:Equation0  //bx + c = 0
    {
        protected double _b;
        protected double _x1;

        public Equation1(double b, double c):base(c)
        {
            _b = b;
        }
        public override void Solve()
        {
            if (_b == 0)
                base.Solve();
            else
            {
                countRes = 1;
                _x1 = - _c/_b;
            }

        }

        public override void PrintResult()
        {
            if(countRes == 1)
            {
                Console.WriteLine($"x = {_x1}");
            }
            else
                base.PrintResult();
        }

        public override string ToString()
        {
            return $"{_b}x + {_c} = 0";
        }

    }
}
