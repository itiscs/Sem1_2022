using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationApp
{
    public class Equation0:Equation  //c = 0
    {
        protected double _c;

        public Equation0(double c)
        {
            _c = c;
        }
        public override void Solve()
        {
            if(_c == 0)
                countRes = int.MaxValue;
            else
                countRes = 0;
        }

        public override void PrintResult()
        {
            if(countRes > 0)
            {
                Console.WriteLine("Ответ - вся числовая ось");
            }
            else
                Console.WriteLine("Нет решения");
        }

        public override string ToString() 
        {
            return $"{_c} = 0";
        }

    }
}
