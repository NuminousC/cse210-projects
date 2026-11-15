
public class Word
{
    private string _text;
    private bool _isHidden;

    // Creates a word and makes it visible initially.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word.
    public void Hide()
    {
        _isHidden = true;
    }

    // Makes the word visible again.
    public void Show()
    {
        _isHidden = false;
    }

    // Checks whether the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the original word or its hidden version.
    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }

        string hiddenText = "";

        foreach (char letter in _text)
        {
            if (char.IsLetter(letter))
            {
                hiddenText += "_";
            }
            else
            {
                // Keep punctuation visible.
                hiddenText += letter;
            }
        }

        return hiddenText;
    }
}
