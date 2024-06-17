// Contoh polymorphism OOP

/*
    Sifat:
    -> Nama method sama dengan parameter yang berbeda
    -> Returnnya tidak boleh berbeda

    Overload
    Overriding => Menulis ulang yang ada di parent
*/

namespace FundamentalUpskilling;
public class Hero
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(Hero hero)
    {
        Console.Write($"{Name} melakukan attack sebesar ");
        Console.WriteLine(BaseDamage);

        hero.GetHit(BaseDamage);

        Console.Write($"{hero.Name} terkena serangan, hp tersisa ");
        Console.WriteLine(hero.HP);
    }

    public void Attack(Monster monster)
    {
        Console.Write($"{Name} melakukan attack sebesar ");
        Console.WriteLine(BaseDamage);

        monster.GetHit(BaseDamage);

        Console.Write($"{monster.Name} terkena serangan, hp tersisa ");
        Console.WriteLine(monster.HP);
    }

    public void GetHit(int damage)
    {
        HP -= damage;
    }
}

public class Game
{
    public static void Main(string[] args)
    {
        var layla = new Hero
        {
            Name = "Layla",
            HP = 100,
            BaseDamage = 10
        };

        var hayabusa = new Hero
        {
            Name = "Hayabusa",
            HP = 100,
            BaseDamage = 20
        };

        Console.WriteLine(hayabusa.HP);

        layla.Attack(hayabusa);

        var orc = new Monster
        {
            Name = "Orc",
            HP = 100,
            BaseDamage = 10
        };

        hayabusa.Attack(orc);
    }
}