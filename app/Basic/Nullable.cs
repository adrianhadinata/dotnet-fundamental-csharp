namespace FundamentalUpskilling;
public class Nullable
{
    public void Main()
    {
        // Error
        // int number = null;
        // int number;

        // tipe data generic <T> = menerima tipe data apapun
        // C# mendukung null safety

        // Cara membuat variable denga tipe data null.
        Nullable<int> number = null;
        int? anotherNumber = null;

        Console.WriteLine(number);
        Console.WriteLine(anotherNumber);

        // Cara validasi

        if (anotherNumber.HasValue)
        {
            Console.WriteLine("Data ada!");
        }
        else
        {
            Console.WriteLine("Error: Data kosong!");
        }

        // sayHello("");

        var name = string.Empty;

        SayHello(null);
        SayHello(name);
    }

    public static void SayHello(string? name)
    {
        if (name != null && name != "")
        {
            Console.WriteLine($"Hello, {name}");
        }
        else{
            Console.WriteLine("Hello There");
        }
    }
}