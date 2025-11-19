namespace hh;

public class Enemy : GameEntity
{
    public Enemy(string name, int health, int damage) : base(name, health, damage)
    {
    }

    public override void PreformAttack(GameEntity e)
    {
        base.PreformAttack(e);
    }
}