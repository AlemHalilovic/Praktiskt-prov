namespace Praktiskt_prov
{
    public class Wizard:Enemy// Klass av wizard som ärver av enemy
    {
        public Wizard(int hp, string name): base (hp,name)// initierar hp, namn och anropar basklassen
        {
            
        }
        public override int Attack()// överskrider attack från enemy klassen
        {
          int damage = 35;//Hur mycket damage den tar
          Console.WriteLine($"Wizard skadade {damage} på dig");// Skriver ut meddelande
          return damage;// returnerar värde
        } 
    }
}