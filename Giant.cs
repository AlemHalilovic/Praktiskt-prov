namespace Praktiskt_prov
{
    public class Giant: Enemy
    {
        public Giant(int hp, string name): base (hp,name){
            
        }
       public override int Attack(){
        int damage = 50;
        Console.WriteLine($"Giant skadade {damage} på dig");
        return damage;
       } 

    }
}