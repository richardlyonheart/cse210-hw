
public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false; //default to visible for all words
    }
    public void Hide()
    {
        _hidden = true; //changes a word from visable to hidden
    }

    public bool IsHidden()
    {
        return _hidden; 
    }

    public string GetDisplayText()
    {
        if (_hidden)
        {
        return new string('_', _text.Length); //changes word to a underscore for each letter
        }
        return _text; // makes new information available to other program
    }
}