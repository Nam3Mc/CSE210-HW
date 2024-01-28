using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false; // Initially all words are visible
    }

    public string GetText()
    {
        if (isHidden)
        {
            return "______"; // Return underscores if word is hidden
        }
        else
        {
            return text;
        }
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}
