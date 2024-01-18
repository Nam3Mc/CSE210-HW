using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write( "What is your grade percentage! " ) ;
        string grade = Console.ReadLine () ;
        int points = int.Parse ( grade ) ;

        string calification = "" ;

        if ( points >= 90 ) 
        { 
            calification = "A" ;
        }

        else if ( points >= 80 ) 
        { 
            calification = "B" ;
        }

        else if ( points >= 70 ) 
        { 
            calification = "C" ;
        }

        else if ( points >= 60 ) 
        { 
            calification = "D" ;
        }

        else
        { 
            calification = "F" ;
        }

        Console.WriteLine ( $"Your grade is : {calification} " ) ;

        if ( points >= 70 )
        {
            Console.WriteLine ( "You passed! " ) ;
        }

        else 
        {
            Console.WriteLine ( "Better luck next time " ) ;
        }

    }
}