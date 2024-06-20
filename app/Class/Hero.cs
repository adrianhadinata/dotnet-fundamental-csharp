// Contoh polymorphism OOP

/*
    Sifat:
    -> Nama method sama dengan parameter yang berbeda
    -> Returnnya tidak boleh berbeda

    Overload => Menulis ulang method dengan parameter yang berbeda
    Overriding 
*/

namespace FundamentalUpskilling;
public class Hero : IHitAble
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(IHitAble hitAble)
    {
        Console.Write($"{Name} melakukan attack sebesar ");
        Console.WriteLine(BaseDamage);

        hitAble.GetHit(BaseDamage);

        // Console.Write($"{hero.Name} terkena serangan, hp tersisa ");
        // Console.WriteLine(hero.HP);
    }

    //Contoh overload
    // public void Attack(Monster monster)
    // {
    //     Console.Write($"{Name} melakukan attack sebesar ");
    //     Console.WriteLine(BaseDamage);

    //     monster.GetHit(BaseDamage);

    //     Console.Write($"{monster.Name} terkena serangan, hp tersisa ");
    //     Console.WriteLine(monster.HP);
    // }

    public void GetHit(int damage)
    {
        HP -= damage;
    }

    public void GetHealthPoint()
    {
        Console.Write("Hp musuh tersisa ");
        Console.WriteLine(HP);
    }
}

public class Game
{
    public void Main(string[] args)
    {
        IHitAble layla = new Hero
        {
            Name = "Layla",
            HP = 100,
            BaseDamage = 10
        };

        IHitAble hayabusa = new Hero
        {
            Name = "Hayabusa",
            HP = 100,
            BaseDamage = 20
        };

        layla.Attack(hayabusa);
        hayabusa.GetHealthPoint();

        IHitAble orc = new Monster
        {
            Name = "Orc",
            HP = 100,
            BaseDamage = 10
        };

        hayabusa.Attack(orc);
        orc.GetHealthPoint();
    }
}