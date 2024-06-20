// Contoh polymorphism OOP

namespace FundamentalUpskilling;
public class Monster : IHitAble
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(IHitAble hitAble)
    {
        Console.Write($"{Name} melakukan attack sebesar ");
        Console.WriteLine(BaseDamage);

        hitAble.GetHit(BaseDamage);

        // Console.Write($"{monster.Name} terkena serangan, hp tersisa ");
        // Console.WriteLine(monster.HP);
    }

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