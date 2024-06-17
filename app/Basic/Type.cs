namespace FundamentalUpskilling;

// Contoh enum diluar class
public enum Direction
{
    North,
    West,
    South,
    East
}

public enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum Role
{
    Manager,
    Admin,
    Customer
}

public enum ErrorCode
{
    NotFound = 101
}

public class Type
{
    // Contoh enum di dalam class
    public enum Gender
    {
        Male,
        Female
    }

    public void Main()
    {
        /*
            Enum
            -> Kumpulan data constant
            --> Contoh:
            ---> Gender: Male, Female
            ---> Mata Angin: Utara, Timur, Selatan, Barat

            -> Enum bisa dibuat dalam Class atau diluar Class
            
            -> Komposisi pembuatan:
            --> accessModifier enum namaEnum

            -> Value enum hanya boleh berisi int
        */

        Console.WriteLine(getGenderMale().ToString());
        Console.WriteLine(getGenderFemale().ToString());

        Console.WriteLine(getNorthDir().ToString());
        Console.WriteLine(getIndexOfAdminRole());

        Console.WriteLine(getValueNotFound());
    }

    public static Gender getGenderMale()
    {
        return Gender.Male;
    }

    public static Gender getGenderFemale()
    {
        return Gender.Female;
    }

    public static Direction getNorthDir()
    {
        return Direction.North;
    }

    public static int getIndexOfAdminRole()
    {
        // casting -> teknik untuk merubah satu tipe data ke tipe data lain
        int adminValue = (int)Role.Admin;
        return adminValue;
    }

    public static int getValueNotFound()
    {
        return (int)ErrorCode.NotFound;
    }
}