namespace FundamentalUpskilling;

public class ExceptionHandling
{
    public void Main(string[] args)
    {
        /*
            Macam - macam exception:
                -> NullReferenceException
                -> IndexOutOfRangeException
                -> ArgumentException
                -> DivideByZeroException
                -> OverflowException
            
            keyword untuk exception :
                try, catch, finally, throw
        */

        // Divide by zero
        
        try 
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            Console.WriteLine(c);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            //melempar kembali error
            // throw;
        }
        finally
        {
            Console.WriteLine("Code setelah try catch");
        }

    }


}