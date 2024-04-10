class MultiFamily : Assets
{
    private int _rent;
    private int _expenses;
    private int _vacant;
    private int _totalUnits;

    public MultiFamily(string name, string description, int rent, int expenses) : base(name)
    {
        _name = name;
        _description = description;
        _rent = rent;
        _expenses = expenses;
        _vacant = Vacant;
        _totalUnits = TotalUnits;
    }
    public int Vacant
    {
        get { return _vacant; }
    }

    public int TotalUnits
    {
        get { return _totalUnits; }
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
        Console.WriteLine($"{Name}, {Description}, Rent: {Rent}, Expenses: {Expenses}, Units: {TotalUnits}, Vacancies: {Vacant}");
    }
}