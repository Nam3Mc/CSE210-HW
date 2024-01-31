using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment ( "Dreiser Morales", "Programing" ) ;
        Console.WriteLine ( assignment1.GetSummary ( ) ) ;

        MathAssignment math1 = new MathAssignment ( "Juan Muñoz", "Divition", "36/5", "87/26" ) ;
        Console.WriteLine ( math1.GetHomeworkList ( ) ) ;

        WritingAssignment writing1 = new WritingAssignment ( "Eva Perez", "Religion", "God Is Not Dead" ) ;
        Console.WriteLine ( writing1.GetStudentName ( ) ) ;
    }
}