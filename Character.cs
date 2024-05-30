namespace Praktiskt_prov
{
   public abstract class Character //Abstrakt klass = visar generisk karaktär
    {
        protected int Hp; //Skyddar och lagrar hp
        private string Name; //Lagrar karaktärens namn och skyddar namnet

        public Character(int hp, string name) // initierar hp o namn
        {
            this.Hp = hp; //Sätter värder
            this.Name = name;// sätter värde
            
        }

        public void SetHealth(int value) //Metod för att sätta health till ett värde
        {
            Hp = value; // Ändrar värdet till de givna värdet
        }
        
        public string GetName() // hämtar karaktärens namn
        {
            return Name; // returnerar namn 
        }
        public int GetHealth() //Metod för att hämta aktuellt hp
        {
            return Hp; // Returnerar värdet hp
        } 
        public void TakeDamage(int damage){  //Metod för att skada karaktärer
            Hp -= damage; // Minskar hp med värdet av damage
            Console.WriteLine($"{Name} tog {damage} skada och har nu bara {Hp} hp kvar"); // skriver ut vad som händer
            
            if (Hp <= 0){ // If sats om man dör
            Console.WriteLine($"{Name} dog");
            }
        }

        public abstract int Attack(); //Abstrakt metod som visar en attack och måste sättas i underklassen
    }
}