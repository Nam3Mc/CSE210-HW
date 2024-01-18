using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayMessage ( ) ;

        string UserName = NameLastnName ( ) ;
        int UserNumber = FavoriteNumber ( ) ;

        int SquaredResult = SquaredNumber ( UserNumber ) ;

        DisplayResult ( UserName, SquaredResult ) ;

        static void DisplayMessage ( )
        {
            Console.WriteLine ( " Welcome to the program " ) ;
        }

        static string NameLastnName ( )
        {
            Console.Write ( "What is your name? " ) ;
            string Name = Console.ReadLine ( ) ;

            return Name ;
        }

        static int FavoriteNumber ( )
        {
            Console.Write ( "What is your favorite number: " ) ;
            int number = int.Parse ( Console.ReadLine ( ) ) ;

            return number ;
        }

        static int SquaredNumber ( int number )
        {
            int square = number * number ;

            return square ;
        }

        static void DisplayResult ( string Name, int square ) 
        {
            Console.WriteLine ( $" {Name}, the the square of your number is {square } " ) ;
        }

    }
}