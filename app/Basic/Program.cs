// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Adrian's Learning DotNet Fundamentals");
namespace FundamentalUpskilling;
public class Program
{
    // Entry poin = program yang akan dijalankan pertama kali
    public void Main()
    {
        Console.WriteLine("Adrian's Learning DotNet Fundamentals"); // line baru

        Console.Write("Go go go!"); // tidak ada baris baru
        Console.Write(" Go go go!"); // tidak ada baris baru

        // variables = implicit, explicit
        int explicitNumber = 10;
        var ImplicitNumber = 10;

        /*
            Number data type

            -> Integer Type:
                byte 8bit
                short 16bit
                int 32bit
                long 64bit
            
            -> Floating Type:
                float 32bit
                double 64bit
                decimal 128bit

            -> ga boleh mines:
                uint
                ulong
                ushort
        */

        // Integer types
        byte byteNumber = 128;
        short shortNumber = 10000;
        int intNumber = 10000000;
        long longNumber = 1000000L;

        // Floating types
        float floatNumber = 3.14f;
        double doubleNumber = 3.14d;
        decimal decimalNumber = 3.14m;

        /*
            String Data Types
        */

        char myChar = 'a';
        string myString = "Adrian";

        /*
            Escape Character
        */

        string myEscapeChar = "This is \"string\"";
        System.Console.WriteLine(myEscapeChar);

        /*
            Verbatim String
            -> ignore escape character
            -> bisa multi line
        */
        string verbatimString = @"\\Data\Adrian";
        System.Console.WriteLine(verbatimString);
    }
}
