using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            //First instance of the Rectangel 
            Rectangle r1 = new Rectangle();
            r1.Length = 8;
            r1.Width = 8;
            double area = r1.CalculateArea();

            Console.WriteLine($"Rectangle 1 - L:{r1.Length}, W:{r1.Width}, A{area}, R:{r1.CalculatePerimeter()}");

            //Second instance of the Rectangle
            Rectangle r2 = new Rectangle(15,11);
            Console.WriteLine($"Rectangle 2 - L:{r2.Length}, W:{r2.Width}, A{r2.CalculateArea()}, R:{r2.CalculatePerimeter()}");
            r2.Width = 10;
            Console.WriteLine("Changed width to 10");
            Console.WriteLine($"Rectangle 2 - L:{r2.Length}, W:{r2.Width}, A{r2.CalculateArea()}, R:{r2.CalculatePerimeter()}");

            //First instance of Circle
            Circle c1 = new Circle();
            c1.Radius = 3.333;
            Console.WriteLine($"C1 - R:{c1.Radius}, A:{c1.CalculateArea()}, P:{c1.CalculatePerimeter()}");

            Circle c2 = new Circle();
            c2.Radius = 4.444;
            Console.WriteLine($"C1 - R:{c2.Radius}, A:{c2.CalculateArea()}, P:{c2.CalculatePerimeter()}");
            Console.WriteLine(c2);
        }
    }
}
