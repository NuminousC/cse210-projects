
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Receives the scripture reference and complete text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Separate the scripture text into individual words.
        string[] words = text.Split(' ');

        // Create a Word object for every word.
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // Hides a specified number of words that are still visible.
    public void HideRandomWords(int numberToHide)
    {
        // Make a list of the positions of words that are not hidden.
        List<int> visibleWordIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                visibleWordIndexes.Add(i);
            }
        }

        // Hide words until the requested number is reached
        // or there are no visible words left.
        int wordsHidden = 0;

        while (wordsHidden < numberToHide &&
               visibleWordIndexes.Count > 0)
        {
            // Select a random position in the list of visible words.
            int randomPosition = _random.Next(visibleWordIndexes.Count);

            // Get the actual position of that word in the scripture.
            int wordIndex = visibleWordIndexes[randomPosition];

            // Hide the selected word.
            _words[wordIndex].Hide();

            // Remove its position so it cannot be selected again
            // during this round.
            visibleWordIndexes.RemoveAt(randomPosition);

            wordsHidden++;
        }
    }

    // Returns the scripture reference and its displayed words.
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    // Checks whether every word has been hidden.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}
