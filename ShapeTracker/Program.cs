using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("Select if you would like to calculate a triangle or rectangle");
      string shapeName = Console.ReadLine();
      if (shapeName == "rectangle")
      {
        Console.WriteLine("We'll calculate the area of the rectangle based on the length and width.");
        Console.WriteLine("Please enter a number for length:");
        string length = Console.ReadLine();
        Console.WriteLine("Please enter a number for width:");
        string width = Console.ReadLine();
        int newLength = int.Parse(length);
        int newWidth = int.Parse(width);
        Rectangle rec = new Rectangle(newLength, newWidth);
        int area = rec.GetArea();
        Console.WriteLine($"The area of your rectangle is {area}.");
        Console.WriteLine("Would you like to check a new shape (new)?");
        Console.WriteLine("Please enter 'new' to check the type of a new shape. To exit, enter any key.");
        string userResponse = Console.ReadLine(); 
        if (userResponse == "new" || userResponse == "New")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye!");
        }
      }
      else 
      {
        Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        int length1 = int.Parse(stringNumber1);  
        int length2 = int.Parse(stringNumber2);  
        int length3 = int.Parse(stringNumber3);  
        Triangle tri = new Triangle(length1, length2, length3);
        ConfirmOrEditTriangle(tri);
      }      
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        tri.Side1 = int.Parse(stringNumber1);  
        tri.Side2 = int.Parse(stringNumber2);  
        tri.SetSide3(int.Parse(stringNumber3)); 
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to see a list of previously-created triangles?");
      string response = Console.ReadLine();
      if (response.ToLower() == "yes")
      {
        List<Triangle> triangleList = Triangle.GetAll();
        foreach (Triangle item in triangleList)
        {
          Console.WriteLine("---------------");
          Console.WriteLine($"Side 1: {item.Side1}");
          Console.WriteLine($"Side 2: {item.Side2}");
          Console.WriteLine($"Side 3: {item.GetSide3()}");
        }
      }
      Console.WriteLine("Would you like to clear the list of previously-created triangles? (yes/no)");
      string clearResponse = Console.ReadLine();
      if (clearResponse.ToLower() == "yes")
      {
        Triangle.ClearAll();
      }
      Console.WriteLine("Would you like to check a new shape (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new shape. To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}