using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _randomGenerator;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _randomGenerator = new Random();

        // Fix the puntuation error
        string[] individualWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string individualWord in individualWords)
        {
            _words.Add(new Word(individualWord));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (_words.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            int index = _randomGenerator.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displaySpecificText = new StringBuilder(_reference.GetDisplayText());
        displaySpecificText.Append("\n"); // Line break.

        // Goes word by word.
        foreach (Word word in _words)
        {
            displaySpecificText.Append(word.GetDisplayText());
            displaySpecificText.Append(" ");
        }

        return displaySpecificText.ToString().TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
