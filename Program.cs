using System;

namespace shapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Triangle triangle = new Triangle("Shapes",45.00, 85.00 );
             Square square = new Square( "Shapes",40.00, 83.00);
             Cube cube = new Cube( "Shapes",70.00, 90.00);
             Rectangle rectangle = new Rectangle( "Shapes",20.00, 14.00);
        }
    }
}
