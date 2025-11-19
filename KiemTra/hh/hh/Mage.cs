namespace hh;

public class Mage : Character
{
    public Mage(string name, int health) : base(name, health)
    {
    }

    public override void UseAbility()
    {
        base.UseAbility();
        Console.WriteLine(Name1 + "Niem chu ngu!");
    }
}