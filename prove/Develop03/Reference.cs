using System;

public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int? endVerse; // For handling verse range

    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (endVerse != null)
        {
            return $"{book} {chapter}:{verse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{verse}";
        }
    }
}
