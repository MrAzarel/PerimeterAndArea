using System;
using System.Drawing;

namespace Perimeter
{

    class Square
    {
        int[] point1 = new int[2];
        int[] point2 = new int[2];
        int[] point3 = new int[2];
        int[] point4 = new int[2];

        bool Equals(int[] point1, int[] point2)
        {
            bool t = point1[0] == point2[0] && point1[1] == point2[1];
            return t;
        }

        bool PerimetrAndArea()
        {
            if (!Equals(point1, point2) && !Equals(point2, point3) && !Equals(point3, point4) && !Equals(point4, point1))
            {
                double a = Math.Cbrt(Math.Sqrt(point2[0] - point1[0]) + Math.Sqrt(point2[1] - point1[1]));
                double b = Math.Cbrt(Math.Sqrt(point3[0] - point2[0]) + Math.Sqrt(point3[1] - point2[1]));
                double c = Math.Cbrt(Math.Sqrt(point4[0] - point3[0]) + Math.Sqrt(point4[1] - point3[1]));
                double d = Math.Cbrt(Math.Sqrt(point1[0] - point4[0]) + Math.Sqrt(point1[1] - point4[1]));
                double perimeter = a + b + c + d;

                double area = Math.Abs((point1[0] - point2[0]) * (point1[1] + point2[1]) + (point2[0] - point3[0]) * 
                    (point2[1] + point3[1]) + (point3[0] - point4[0]) * (point4[1] + point4[1]) + (point4[0] - point1[0]) * 
                    (point4[1] + point1[1])) / 2;
            }
            else
                return false;
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}