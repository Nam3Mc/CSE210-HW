using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction () ;
        Console.WriteLine ( f1.GetFractionString ( ) ) ;
        Console.WriteLine ( f1.GetDecimalString ( ) ) ;

        Fraction f2 = new Fraction ( 5 ) ;
        Console.WriteLine ( f2.GetFractionString ( ) ) ;
        Console.WriteLine ( f2.GetDecimalString ( ) ) ;

        Fraction f3 = new Fraction ( 1, 1 ) ;
        Console.WriteLine ( f3.GetFractionString ( ) ) ;
        Console.WriteLine ( f3.GetDecimalString ( ) ) ;
   

    }
}