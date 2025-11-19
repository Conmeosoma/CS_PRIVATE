namespace hh;

public class Wizard
{
    private String Name;
    private int Damage;
    private int Mana;

    public Wizard(string name, int damage, int mana)
    {
        Name = name;
        Damage = damage;
        Mana = mana;
    }

    public string Name1
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Damage1
    {
        get => Damage;
        set => Damage = value;
    }

    public int Mana1
    {
        get => Mana;
        set => Mana = value;
    }

    public void CastSpell()
    {
        Console.WriteLine(Name + " Tung truong kamehahahahha gay" + Damage + "Sat thuong va mat " + Mana + " Mana !"  );
    }
}