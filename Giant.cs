namespace Praktiskt_prov
{
    public class Giant: Enemy // Klass för Gian som ärver av Enemy
    {
        public Giant(int hp, string name): base (hp,name)// konstruktor, initierar hp, namn o anropar basklass
        {
            
        }
    
        public override int Attack()//Överskrider metoden attack av Enemy klassen
        { 
           int damage = 50;//Hur mycket skada giant gör
           Console.WriteLine($"Giant skadade {damage} på dig");// Skriver ut meddelande
           return damage;//returnerar damage
        } 

    }
}