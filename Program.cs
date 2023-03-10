using System;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of dot A:");
            Console.Write("X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter coordinates of dot B:");
            Console.Write("X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter coordinates of dot C:");
            Console.Write("X: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y3 = double.Parse(Console.ReadLine());

            // Calculate length of triangle 
            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine($"\nLength of AB is: {AB:F2}");
            Console.WriteLine($"Length of BC is: {BC:F2}");
            Console.WriteLine($"Length of AC is: {AC:F2}");

            // Check if it's an equilateral triangle
            bool isEquilateral = AB == BC && BC == AC;
            Console.WriteLine($"\nIs it an equilateral triangle? {isEquilateral}");

            // Check if it's an isosceles triangle
            bool isIsosceles = AB == BC || BC == AC || AC == AB;
            Console.WriteLine($"Is it an isosceles triangle? {isIsosceles}");

            // Check if it's a right triangle
            bool isRight = false;
            if (Math.Pow(AB, 2) == Math.Pow(BC, 2) + Math.Pow(AC, 2)
                || Math.Pow(BC, 2) == Math.Pow(AB, 2) + Math.Pow(AC, 2)
                || Math.Pow(AC, 2) == Math.Pow(AB, 2) + Math.Pow(BC, 2))
            {
                isRight = true;
            }
            Console.WriteLine($"Is it a right triangle? {isRight}");

            // Calculate perimeter of the triangle
            double perimeter = AB + BC + AC;
            Console.WriteLine($"\nPerimeter of the triangle: {perimeter:F2}");

            // Print even numbers up to the triangle perimeter
            Console.Write("\nParity numbers in range from 0 to the triangle perimeter: ");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
