// Contoh polymorphism OOP

namespace FundamentalUpskilling;
public class Monster
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }

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