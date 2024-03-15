using System.Reflection.Metadata.Ecma335;

public class Reference
{
    private string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }
    public string GetDisplayText()
    {
       return _reference; //puts the reference out for access to other program
    }
}