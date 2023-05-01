using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
// using System.Collections.Generic;
// using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2,5);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnLength_Int()
    {
      //Arrange
      int length = 2;
      Rectangle newRectangle = new Rectangle(length,5);
      //Act
      int result = newRectangle.Length;
      //Assert
      Assert.AreEqual(length, result);
    }

    [TestMethod]

    public void SetLength_SetsValueOfLength_Void()
    {
      //Arrange
      Rectangle newRectangle = new Rectangle(2,5);
      int newLength = 10;
      //Act
      newRectangle.Length = newLength;
      //Assert
      Assert.AreEqual(newLength, newRectangle.Length);
    }

    [TestMethod]
    public void GetWidth_ReturnWidth_Int()
    {
      //Arrange
      int width = 5;
      Rectangle newRectangle = new Rectangle(2,width);
      //Act
      int result = newRectangle.Width;
      //Assert
      Assert.AreEqual(width, result);
    }
    
    [TestMethod]
    public void SetWidth_SetsValueOfWidth_Void()
    {
      //Arrange
      Rectangle newRectangle = new Rectangle(2,5);
      int newWidth = 20;
      //Act
      newRectangle.Width = newWidth;
      //Assert
      Assert.AreEqual(newWidth, newRectangle.Width);
    }

    [TestMethod]
    public void GetArea_ReturnsRectangleArea_Int()
    {
      //Arrange
      Rectangle newRectangle = new Rectangle(2,5);
      int newArea = 10;
      //Act
      int area = newRectangle.GetArea();
      //Assert
      Assert.AreEqual(newArea, area);
    }
  }
}