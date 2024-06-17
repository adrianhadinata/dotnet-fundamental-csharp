namespace FundamentalUpskilling;
public class UserInput
{
    public void Main()
    {
        var a = 10;

        Console.WriteLine("Enter a number for sum by 10: ");

        var b = Console.ReadLine();
        var c = a + Convert.ToInt32(b);

        System.Console.WriteLine("Convert String to " + c.GetType());
        Console.WriteLine(c);
    }
}