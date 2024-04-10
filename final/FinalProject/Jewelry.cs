class Jewelry : Assets
{
    public Jewelry(string name, string description, int value) : base(name)
    {
    }

    public override void DisplayValue()
    {
        Console.WriteLine($"{Name}, {Value}");
    }
}