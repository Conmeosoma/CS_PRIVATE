namespace Game;

public abstract class Character
{
    private int posX, posY;
    private int damage;
    private int rangeAttack;
    private int health;

    protected Character()
    {
    }

    protected Character(int posX, int posY, int damage, int rangeAttack, int health)
    {
        this.posX = posX;
        this.posY = posY;
        this.damage = damage;
        this.rangeAttack = rangeAttack;
        this.health = health;
    }

    public int PosX
    {
        get => posX;
        set => posX = value;
    }

    public int PosY
    {
        get => posY;
        set => posY = value;
    }

    public int Damage
    {
        get => damage;
        set => damage = value;
    }

    public int RangeAttack
    {
        get => rangeAttack;
        set => rangeAttack = value;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }
    
    public virtual void TakeDamage(int amount)
    {
        Health -= (int)damage;
        if (Health <= 0)
        {
            Health = 0;
        }
    }

    public void MoveTo(int newX, int newY)
    {
        posX = newX;
        posY = newY;
    }

    public bool IsInRange(Character target)
    {
        int dx = Math.Abs(PosX - target.PosX);
        int dy = Math.Abs(PosY - target.PosY);
        return dx + dy <= RangeAttack;
    }
    public abstract void Attack(Character target);
}

