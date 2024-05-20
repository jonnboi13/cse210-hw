public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        this.numerator = 1;
        this.denominator = 1;
    }

    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    private int GetNumerator()
    {
        return this.numerator;
    }

    private void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    private int GetDenominator()
    {
        return this.denominator;
    }

    private void SetDenominator(int denominator)
    {
        this.denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{this.numerator}/{this.denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)this.numerator / this.denominator;
    }
}