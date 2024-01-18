using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write( "What is the magic number ? " ) ;
        //int number = int.Parse ( Console.ReadLine () ) ;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

         int guess = -1 ;

        while ( guess != number )
    
        {
            Console.Write ( "What is your guess ? " ) ;
            guess = int.Parse ( Console.ReadLine () ) ;

            if ( number > guess ) 
            {
                Console.WriteLine ( " The number is Higer " ) ;
            }

            else if ( number < guess ) 
            {
                Console.WriteLine ( " The numver is lower " ) ;
            }

            else
            {
                Console.WriteLine ( " Your Guess is Right! " ) ;
            }
        }
    }



}