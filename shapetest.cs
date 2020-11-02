using System;
namespace shapeTest
{
    public class shape
    {
        public double X {get; set;}

        public double Y {get; set;}

        public shape(double x,double y)
        {
        
            X = x;
            Y = y;
            
        }

        public virtual double Area()
        {
            return X * Y;
        }
    }

    public class Triangle : shape
    {


        public string Triangleshape{get; set;}

        public Triangle ( string trianglesshape, double X, double Y):base(X,Y)
        {
        
            Triangleshape = trianglesshape;

        }

         public override double Area()
        {
           double result;
           result = X * Y;
           return result / 2;
        }
    }


    public class Rectangle : shape
    {
        public string RectangleShape  {get; set; }

    
    
  
   public Rectangle(string rectangleshape , double X, double Y):base(X,Y)
   {

    RectangleShape = rectangleshape;

   }

    public override double Area()
    {
      return X * Y;
    }

 }  



     public class Square : shape
    {
        public string SquareShape  {get; set; }

    public Square(string squareshape , double X, double Y):base(X,Y)
   {

    SquareShape = squareshape;

   }

    public override double Area()
    {
      return 4* X ;
    }

 }  


 public class Cube : shape
    {
        public string CubeShape  {get; set; }

    public Cube(string cubeshape , double X, double Y):base(X,Y)
   {

    CubeShape = cubeshape;

   }

    public override double Area()
    {
      return 6* X ;
    }

 }  


}