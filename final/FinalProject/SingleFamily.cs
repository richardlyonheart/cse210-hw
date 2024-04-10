class SingleFamily : Assets
{
    private int _rent;
    private int _expenses;
    public SingleFamily(string name, string description, int rent, int expenses) : base(name)
    {
        _name = name;
        _description = description;
        _rent = rent;
        _expenses = expenses;
    }
    public int Rent
    {
        get { return _rent; }
    }


    public int Expenses
    {
        get { return _expenses; }
    }

    public override void DisplayValue()
    {
        Console.WriteLine($" {Name}, {Description}, {Rent}");
    }
}