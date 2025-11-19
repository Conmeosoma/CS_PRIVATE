namespace hh;

public class Player : GameEntity
{
    public Player(string name, int health, int damage) : base(name, health, damage)
    {
        
    }

    public override void PreformAttack(GameEntity e)
    {
        base.PreformAttack(e);
    }
}