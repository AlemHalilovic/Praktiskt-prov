namespace Praktiskt_prov
{
    public class Rat:Enemy
    {
           public Rat(int hp, string name): base (hp,name){
            
        }
       public override int Attack(){
        int damage = 5;
        Console.WriteLine($"Rat skadade {damage} på dig");
        return damage;
       } 
    }
}