class Cars : Assets
{
    public Cars(string name, string description, int value): base(name)
    {
        _description = description;
        _value = value;
    }
    public override void DisplayValue()
    {
        Console.WriteLine($"{Description}, {Value}");
    }
}

