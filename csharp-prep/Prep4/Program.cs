using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = -1 ;
        List<int> numbers = new List<int> () ;

        while ( number != 0 )
        {
            Console.Write( "Type 0 to leave or other number to continue: " ) ;

            string userNumber = Console.ReadLine ( ) ;
            number = int.Parse ( userNumber ) ;

            if ( number != 0 ) 
            {
                numbers.Add ( number ) ;
            }

        }

        int sum = 0 ;

        foreach ( int i in numbers )
        {
            sum += i ;
        }

        Console.WriteLine ( $"The sum is: {sum} " ) ;

        float averange = ( ( float ) sum ) / numbers.Count ;
        Console.WriteLine ( $"The averange is: {averange} " ) ;

        int max = numbers [0] ;

        foreach ( int i in numbers ) 
        { 
            if ( i > max ) 
            {
                max = i ;
            }
        }

        Console.WriteLine ( $"The max is: { max } " ) ;
    }
}