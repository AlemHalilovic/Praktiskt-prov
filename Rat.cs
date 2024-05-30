namespace Praktiskt_prov
{
public class Rat:Enemy // Rat klass som ärver av enemy
{
    public Rat(int hp, string name): base (hp,name)// Konstruktor initierar hp, namn och anropar basklass   
    {

    }
     
    public override int Attack()//överskrider attack metod av Enemy klassen   
    { 
      int damage = 5; //Hur mycket damage den tar
      Console.WriteLine($"Rat skadade {damage} på dig");//SKriver ut meddelande        
      return damage;//returnerar damge
    } 
  }
}