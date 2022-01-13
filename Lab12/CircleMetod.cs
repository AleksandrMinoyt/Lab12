using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    public static class CircleMetod
    {
        static public double Length(double radius)
        {
            double result = 2 * Math.PI * radius;
            return result;
        }
        static public double Square(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }

        static public bool CheckEntry(double radius, double coord_x, double coord_y)
        {
            bool result = (Math.Sqrt(Math.Pow(coord_x, 2) + Math.Pow(coord_y, 2))) < radius;
            return result;
        }


    }
}
