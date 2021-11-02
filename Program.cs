using System;

namespace OperatorExercisePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(Math.PI, radius);
            Console.WriteLine(area);
        }

        public static double AreaOfCircle(double Pi, double radius)
        {
            double area = Pi * (radius * radius);
            return area;
        }
        
    }
}
