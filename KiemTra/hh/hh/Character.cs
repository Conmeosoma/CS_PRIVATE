namespace hh;

public abstract class Character
{
    private string Name;
    private int Health;

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public string Name1
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Health1
    {
        get => Health;
        set => Health = value;
    }

    public virtual void UseAbility()
    {
        
    }

    
}