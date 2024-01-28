using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public Reference GetReference()
    {
        return reference;
    }

    public List<Word> GetWords()
    {
        return words;
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
