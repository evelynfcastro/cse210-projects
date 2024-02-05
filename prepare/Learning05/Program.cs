using System;

class Program
{
    static void Main(string[] args)

    {

         List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 4);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("pink", 4,3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("green", 3);
        shapes.Add(circle1);
       
      

        foreach (Shape sh in shapes)
        {
            Console.WriteLine($"The {sh.GetColor()} shape has an area of {sh.GetArea()} ");
        }
            }

}