using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); //takes the paragraph and splits it to words
    }
    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

        if (unhiddenWords.Count >0 ) //checks for visible words
        {
            int randomIndex = random.Next(0,unhiddenWords.Count); //counts up until all worlds hidden
            unhiddenWords[randomIndex].Hide(); //randomly hides some words
        }
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"Reference: {_reference}"); //writes the reference
        foreach (Word word in _words)//for each word in the encapsulated words program
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine(); //Space for readability
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(Word => Word.IsHidden()); //hides all words
    }
}