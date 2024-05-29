namespace Praktiskt_prov
{
    public class Wizard:Enemy
    {
           public Wizard(int hp, string name): base (hp,name){
            
        }
       public override int Attack(){
        int damage = 35;
        Console.WriteLine($"Wizard skadade {damage} på dig");
        return damage;
       } 
    }
}