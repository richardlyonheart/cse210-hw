using System.Reflection.Metadata.Ecma335;

public class Fraction
{
private int _num;

private int _den;

public Fraction()
{
    _num = 1;
    _den = 1;
}

public Fraction(int num)
{
    _num = num;
    _den = 1;
}

public Fraction(int num, int den)
{
    _num = num;
    _den = den;
}

public void setDen(int den)
{
    _den = den;
}
public void setNum(int num)
{
    _num = num;
}
public string GetFractionString()
{
    string text =$"{_num}/{_den}";
    return text;
}
public double GetDecimalValue()
{
    return (double)_num / (double)_den;
}

}