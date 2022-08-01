using static System.Math;

namespace Shape
{


    public static class ShapeCalculator
    {



        private class ShapeValidation
        {
            public static void CricleValidation(double r)
            {
                if (r <= 0) throw new ArgumentException("Радиус круга не может быть меньше и/или равным нулю");
            }

            public static void TriangleValidation(double a, double b, double c)
            {
                if (a <= 0 && b <= 0 && c <= 0) throw new ArgumentException("Стороны треугольника не могут быть меньше и/или равным нулю");
                if (!(a + b > c && b + c > a && a + c > b)) throw new ArgumentException("Указанный треугольник не существует");
            }
        }



        public class ShapeData
        {

            public static bool IsTrianglePryamoug(double a, double b, double c)
            {
                ShapeValidation.TriangleValidation(a, b, c);

                return Pow(a, 2) == Pow(b, 2) + Pow(c, 2) 
                    || Pow(b, 2) == Pow(a, 2) + Pow(c, 2) 
                    || Pow(c, 2) == Pow(a, 2) + Pow(b, 2);
            }

        }



        public static double GetCricleSqare(double r)
        {
            ShapeValidation.CricleValidation(r);

            return PI * Pow(r, 2);
        }

        public static double GetTriangleSqare(double a, double b, double c)
        {
            ShapeValidation.TriangleValidation(a, b, c);

            double p = (a + b + c) / 2;
            return Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}