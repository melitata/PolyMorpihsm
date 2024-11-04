using System;


public abstract class BaseGeometrikSekil
{
    public double Width { get; set; }
    public double Height { get; set; }
    public abstract double CalculateArea();
}


public class Kare : BaseGeometrikSekil
{
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class Dikdortgen : BaseGeometrikSekil
{
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class DikUcgen : BaseGeometrikSekil
{
    public override double CalculateArea()
    {
        return (Width * Height) / 2;
    }
}

class Program
{
    static void Main()
    {
        Kare kare = new Kare
        {
            Width = 5,
            Height = 5
        };
        Console.WriteLine($"Karenin Alanı: {kare.CalculateArea()}");

        Dikdortgen dikdortgen = new Dikdortgen
        {
            Width = 4,
            Height = 7
        };
        Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.CalculateArea()}");

        DikUcgen dikUcgen = new DikUcgen
        {
            Width = 6,
            Height = 8
        };
        Console.WriteLine($"Dik Üçgenin Alanı: {dikUcgen.CalculateArea()}");
    }
}
