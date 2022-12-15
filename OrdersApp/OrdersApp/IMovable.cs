using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public interface IMovable
    {
        void Move(double x, double y);
        double Sum { get; }
    }



    public class Point:IMovable
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double x, double y)
        {
            this.x += x;
            this.y += y;
        }

        public double Sum
        {
            get { return x + y; }
        }



    }

}
