namespace hh;

public class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health)
    {
        
    }
    // void UseAbility()
    // {
    //     Console.WriteLine(Name1 + "Dung xoay bua!");
    // }
    public override void UseAbility()
    {
        base.UseAbility();
        Console.WriteLine(Name1 + " Dung Xoay bua!");
    }
}