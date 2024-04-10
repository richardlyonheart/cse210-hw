using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

abstract class Assets
{
    protected string _name;
    protected string _description;
    protected int _value;

    public Assets(string name)
    {
        _name = name;
        _description = "";
        _value = 0;
    }
    public string Name
    {
        get {return _name;}
    }
    public string Description
    {
        get { return _description;}
    }
    public int Value
    {
        get {return _value;}
    }

     public abstract void DisplayValue();

}