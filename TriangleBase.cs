using System;

namespace UL.TriangleCheck
{
    public class TriangleBase
    {

        // Function to check if the triangle
        // is equilateral or isosceles or scalene
        public static string CheckTriangle(int x, int y, int z)
        {
            // Check for error 
            if (x + y <= z || x + z <= y || z + y <= x)
                return "Error";
            // Check for equilateral triangle
            if (x == y && y == z)
                return "Equilateral Triangle";
            //  Console.WriteLine("Equilateral Triangle");

            // Check for isosceles triangle
            else if (x == y || y == z || z == x)
                return "Isosceles Triangle";
            //   Console.WriteLine("Isosceles Triangle");

            // Otherwise scalene triangle
            else
            return  "Scalene Triangle";
               // Console.WriteLine("Scalene Triangle");
        }
    }
}