namespace hh;

public abstract class GameEntity
{
    
    public String name;
    public int health;
    public int damage;

    public string Name
    {
        get ;
        set ;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }

    public int Damage
    {
        get => damage;
        set => damage = value;
    }


    protected GameEntity(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }


    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
        }

        Console.WriteLine($"gay  {damage} sat thuong!.  {this.Name} con lai: {Health} Hp" );
    }

    public Boolean IsAlive()
    {
        if (Health < 0)
        {
            return false;
        }

        return true;
    }

    public virtual void PreformAttack(GameEntity e)
    {
        if (e != null)
        {
            Console.Write($"{this.Name} tan cong {e.Name} ,");
            e.TakeDamage(this.Damage);
            
        }
    }
}