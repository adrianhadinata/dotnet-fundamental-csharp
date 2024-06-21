namespace FundamentalUpskilling;

public class CustomException
{
    public  void Main(string[] args)
    {
        
    }
}

public class NotFoundException : Exception
{
    public NotFoundException(string? message) : base()
    {

    }
}