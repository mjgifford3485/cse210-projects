using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        fraction1.Display();
        fraction2.Display();
        fraction3.Display();

        Fraction fraction4 = new Fraction();
        fraction4.SetTop(5);
        fraction4.SetBottom(8);

        Console.WriteLine($"{fraction4.GetTop()}/{fraction4.GetBottom()}");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction();
        Fraction f3 = new Fraction();
        Fraction f4 = new Fraction();

        f1.SetTop(1);
        f1.SetBottom(1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        f2.SetTop(5);
        f2.SetBottom(1);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        f4.SetTop(1);
        f4.SetBottom(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}