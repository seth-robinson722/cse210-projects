using System;
using System.Collections.Generic;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold Shape objects
            List<Shape> shapes = new List<Shape>();

            // Add different types of shapes to the same list
            shapes.Add(new Square("Red", 4));
            shapes.Add(new Rectangle("Blue", 5, 10));
            shapes.Add(new Circle("Green", 3));

            Console.WriteLine("Iterating through the shapes list:");
            Console.WriteLine("---------------------------------");

            foreach (Shape s in shapes)
            {
                // Polymorphism in action: 
                // 's' is a Shape, but it knows which GetArea() to call at runtime!
                string color = s.GetColor();
                double area = s.GetArea();

                Console.WriteLine($"The {color} shape has an area of: {area:F2}");
            }
        }
    }
}