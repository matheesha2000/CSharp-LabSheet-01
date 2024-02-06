using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Rectangle Area Calculator!");
        
        // Prompt the user to enter length and width
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the area
        double area = CalculateRectangleArea(length, width);
        Console.WriteLine($"The area of the rectangle with length {length} and width {width} is: {area}");

        Console.ReadLine(); // To keep the console window open until the user presses Enter
    }

    // Function to calculate the area of a rectangle
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
}
