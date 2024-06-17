// Contoh Encapsulation OOP

namespace FundamentalUpskilling;
public class Car
{
    /*
        Class = Blueprint
        -> dengan opp kita bisa buat kode menjadi reusable

        Object = representasi dari blueprint
        
        Attribute / property dari car: kaca, ban, warna, bahan bakar, mesin.

        Method dari car: drive, stop, beep, etc.

        Jika membuat attribute di C# tidak menggunakan access modifier, dia dianggap private sehingga tidak bisa diakses

        Ada 4 pilar OOP
        -> Encapsulation = membatasi akses
        -> Inheritance = menghubungkan
        -> Polymorphism = menggabungkan
        -> Abstraction = menghilangkan

        Access Modifier : 
        -> public       = Bisa diakses dimanapun, class manapun, file manapun
        -> protected    = Bisa diakses di turunanya / children
        -> private      = Hanya bisa diakses diri sendiri
        -> internal     = Hanya bisa diakses di namesapace yang sama

        Struktur C# :
        -> Solution / Rumah
        --> Project / Namespace / Kamar
    */

    // Ini untuk Dirct access (Not secure)
    // public string Color;
    // public string Brand;
    // public int Fuel;

    // private string _color;
    // private string _brand;
    // private int _fuel;

    // Cara ke 2
    // public string Color
    // {
    //     get { return _color; }
    //     set 
    //     { 
    //         if (value != "") _color = value;
    //     }
    // }

    // Cara ke 3 (Lebih mudah)
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Fuel { get; set; }

    // Constructor Function (bisa lebih dari 1)
    // public Car(string color, string brand, int fuel)
    // {
    //     Color = color;
    //     Brand = brand;
    //     Fuel = fuel;

        // _color = color;
        // _brand = brand;
        // _fuel = fuel;
    // }

    // public Car()
    // {
    // }

    // Getter Setter with Method (Seperti java)
    // public string GetColor()
    // {
    //     // return Color;
    //     return _color;
    // }

    // public void SetColor(string color)
    // {
    //     // Color = color;
    //     _color = color;
    // }

    // Cara ke 2
}

public class CarProgram
{
    public void Main(string[] args)
    {
        // object / instance object / membuat objet car baru
        // Car ayla = new Car("Red", "Ayla", 50);
        // var supra = new Car("Black", "Supra", 0);
        // var rush = new Car();

        // ayla.Fuel = 100;
        // supra.Fuel = 50;

        // Direct access (Not Secure)

        // Console.WriteLine(ayla.Fuel);
        // Console.WriteLine(supra.Fuel);
        // Console.WriteLine(rush.Fuel);

        // rush.Brand = "Rush";
        // rush.Color = "Blue";
        // rush.Fuel = 90;

        // Console.WriteLine(rush.Fuel);

        // Getter Setter with Method (Seperti java)

        // Console.WriteLine(ayla.GetColor());
        // Console.WriteLine(supra.GetColor());
        // Console.WriteLine(rush.GetColor());

        // rush.SetColor("Blue");

        // Console.WriteLine(rush.GetColor());

        // Cara ke 2
        // rush.Color = "Blue";

        // Console.WriteLine(rush.Color);

        // Cara ke 3 (Tanpa Constructor)
        var rush = new Car
        {
            Color = "Blue",
            Brand = "Rush",
            Fuel = 90
        };

        Console.WriteLine(rush.Color);
    }
}