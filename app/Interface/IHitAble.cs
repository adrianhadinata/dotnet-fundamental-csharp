namespace FundamentalUpskilling;

// Interface harus diawali dengan huruf "I"

public interface IHitAble
{
    void GetHit(int damage);
    void Attack(IHitAble hitAble);
    void GetHealthPoint();
}