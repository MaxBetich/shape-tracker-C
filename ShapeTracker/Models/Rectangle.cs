//using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _length;
    public int Length
    {
      get { return _length; }
      set { _length = value; }
    }
    private int _width;
    public int Width
    {
      get { return _width; }
      set { _width = value; }
    }
    public Rectangle(int length, int width)
    {
      _length = length;
      _width = width;
    }

    public int GetArea()
    {
      return (_length*_width);
    }
  }
}