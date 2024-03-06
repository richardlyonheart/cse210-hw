public class Date
{
    public string _date;
    public string _location;

    public Date()
    {}

    public void ShowDate()
    {
        Console.WriteLine($"{_date}, {_location}.");
    }
}