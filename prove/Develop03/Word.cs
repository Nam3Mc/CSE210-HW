using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false; 
    }

    public string GetText()
    {
        if (isHidden)
        {
            return "______"; 
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
