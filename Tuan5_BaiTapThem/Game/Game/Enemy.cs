namespace Game;
public class Enemy : Character
{
    public string EnemyType;
    public Enemy(int x, int y, int damage, int rangeAttack, int health, string type)
        : base(x, y, damage, rangeAttack, health)
    {
        EnemyType = type;
    }
    public string EnemyType1
    {
        get => EnemyType;
        set => EnemyType = value ?? throw new ArgumentNullException(nameof(value));
    }
    public override void Attack(Character target)
    {
        if (!IsInRange(target))
        {
            Console.WriteLine("EnemyType");
            return;
        }

        Console.WriteLine("Tan cong gay" + Damage + "sat thuong!");
        target.TakeDamage(Damage);
    }
}