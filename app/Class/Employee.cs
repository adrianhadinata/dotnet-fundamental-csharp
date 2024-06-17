// Contoh inheritance OOP

namespace FundamentalUpskilling;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Division { get; set; }

    // tambahkan virtual agar dapat di override / overwrite
    public virtual void SayHello(Employee employee)
    {
        Console.WriteLine($"Hello, {employee.Name}");
    }
}

/*
    Inheritance: pewarisan yang menurunkan attribute ataupun method di OOP

    keyword untuk inheritance :(:)

    base => keyword mengakses parent class

    method overload = membuat method dengan nama yang sama tetapi parameter yang berbeda

    method override = overwrite, menuliskan ulang kode method dari parent
*/

public class Manager : Employee
{
    // Membuat 2 method yang berbeda, memakan lebih banyak resources
    // public void SayHello(Employee employee)
    // {
    //     base.SayHello(employee);
    // }

    public override void SayHello(Employee employee)
    {
        Console.WriteLine($"Hello {employee.Name}, This is your manager {Name}");
    }
}

public class Supervisor : Employee
{
    public override void SayHello(Employee employee)
    {
        Console.WriteLine($"Hello {employee.Name}, This is your supervisor {Name}");
    }

    public void SayHi()
    {
        Console.WriteLine($"Hi {Name}");
    }
}

public class ProgramEmployee
{
    public void Main(string[] args)
    {
        // var manager = new Manager
        // {
        //     Id = "001",
        //     Name = "Adrian",
        //     Division = "IT"
        // };

        // var employee = new Employee
        // {
        //     Id = "002",
        //     Name = "Hadi",
        //     Division = "IT"
        // };

        // manager.SayHello(employee);

        Supervisor hadinata = new Supervisor();
        Employee hadi = new Supervisor();
        Manager adrian = new Manager();

        hadinata.Name = "Hadinata";
        hadi.Name = "Hadi";
        adrian.Name = "Adrian";

        hadinata.SayHi();
        hadinata.SayHello(hadi);
        adrian.SayHello(hadi);
    }
}