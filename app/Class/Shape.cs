// Contoh abstract OOP
namespace FundamentalUpskilling;

/*
    Perbedaan antara virtual dan abstract: virtual itu pewarisan sebuah method / attribute namun tidak wajib di override, kalau abstract wajib di override (Karena parent belum jelas)
*/

public abstract class Shape
{
    public abstract double GetSurface();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }
    
    public override double GetSurface()
    {
        return Width * Length;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    
    public override double GetSurface()
    {
        return Base * Height / 2;
    }
}

public class ProgramShape
{
    public void Main()
    {
        var rectangle = new Rectangle
        {
            Width = 10,
            Length = 20
        };
        
        var triangle = new Triangle
        {
            Base = 20,
            Height = 10
        };
        
        Console.WriteLine(rectangle.GetSurface());
        Console.WriteLine(triangle.GetSurface());
    }
}