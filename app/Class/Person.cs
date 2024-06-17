namespace FundamentalUpskilling;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonProgram
{
    public void Main()
    {
        var budi = new Person
        {
            Name = Util.Input("Masukkan nama anda"),
        };

        Console.WriteLine(budi.Name);
    }
}

public class Util
{
    public static string Input(string info)
    {
        while (true)
        {
            Console.Write($"{info}: ");
            var input = Console.ReadLine();
            if (input is null or "") continue;
            return input;
        }
    }
}