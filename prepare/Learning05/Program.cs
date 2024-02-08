using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> ( ) ;

        Square a = new Square ( "red", 6 ) ;
        shapes.Add ( a ) ;

        Rectangle b = new Rectangle ( "white", 8, 10 ) ;
        shapes.Add ( b ) ;

        Circle c = new Circle ( "black", 15 ) ;
        shapes.Add ( c ) ;

        foreach ( Shape i in shapes ) 
        {
            string color = i.GetColor ( ) ;

            double area = i.GetArea ( ) ;

            Console.WriteLine ( $" The {color} shape has an area of {area} " ) ;

        }
    }

}