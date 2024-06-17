namespace FundamentalUpskilling;
public class Method
{
    /*
        Access Modifier : 
            -> static : Hanya bisa dipanggil oleh sesama static method 
            -> no static
        Return type : void(no returning anything) / data types
        Method Name : PascalCase
    */
    public void Main() 
    {
        Console.WriteLine("Method");

        SayHello();
        SayName("Adrian");

        Console.WriteLine(SumTwoValue(10, 20));

        // Anonymous function (hanya bisa di local)
        var anonymousFunction = delegate(string sentences)
        {
            Console.WriteLine(sentences);
        };

        anonymousFunction("Ini adalah anonymous function");

        var simpleAnonyousFunction = (string sentences) => 
        {
            Console.WriteLine(sentences);
        };

        simpleAnonyousFunction("Ini adalah simple anonymous function");
    }

    static void SayHello()
    {
        Console.WriteLine("Hello");
    }

    static void SayName(string name)
    {
        Console.WriteLine(name);
    }

    static int SumTwoValue(int a, int b)
    {
        return a + b;
    }
}