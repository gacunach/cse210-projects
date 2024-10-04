using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();


        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hiddenCount = 0;
         List<int> unhiddenIndexes = new List<int>();

        // Find all indexes of words that are not yet hidden
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                unhiddenIndexes.Add(i);
            }
        }

        // Shuffle and hide words
        while (hiddenCount < numberToHide && unhiddenIndexes.Count > 0)
        {
            int randomIndex = random.Next(unhiddenIndexes.Count);
            int wordIndex = unhiddenIndexes[randomIndex];
            _words[wordIndex].Hide();
            unhiddenIndexes.RemoveAt(randomIndex); 
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (var word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
            
        }

        return true;
    }
}