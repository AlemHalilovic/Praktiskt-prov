namespace Praktiskt_prov
{
    class Player : Character// Klass visar spelaren och ärver från Character
    {
        
        private int ZapUses = 10;// Private för att hålla antalet användningar av attacker kvar
        private int FireBallUses = 5;
        private int LightningUses = 2;

        private int damage = 0; // Sätter damage till 0 men byter det senare

        public Player(int hp, string name) : base(hp, name) // initierar spelarens hp och namn samt anropar basklass
        { 

        }

        public override int Attack() //överskrider metoden attack från Character, används dock inte 
        {
          return damage ; // Returnerar förberedd skada
        }

        public void AttackChoice()// Metod för att välja spelarens attack
        {
             
            int attackChoice = int.Parse(Console.ReadLine());// Läser av det usern väljer och lägger det i attackchoice
            switch (attackChoice)// En switch med attackchoice i för att den sedan ska utföra olika cases beroende på attackchoice värdet
            {

            case 1: // Första zap case
                if(ZapUses > 0)// Om zapuses inte är 0
                {
                    damage = 10;// Skadar 10
                    ZapUses--;// tar bort en zapuse varje gång den används
                    Console.WriteLine($"{GetName()} använde Zap och gjorde {damage} damage, du har nu:{ZapUses} kvar");// skriver ut meddelande
                }
                else 
                {
                    Console.WriteLine("Du har inga Zaps kvar");// Det här händer om vi inte har zapuses kvar
                }
                break;//avslutar grenen

             case 2: // Case 2 för fireball (Om usern väljer 2)
                if(FireBallUses > 0)// om fireballuses är mer än 0 så händer det under
                {
                    damage = 20;// Den gör 20 damage
                    FireBallUses--;// Minskar uses
                    Console.WriteLine($"{GetName()} använde Fireball och gjorde {damage} damage, du har nu:{FireBallUses} kvar");//Meddelande
                }
                else 
                {
                    Console.WriteLine("Du har inga Fireballs kvar");// inga uses kvar så händer detta
                }
                break;


            case 3: //Case för lightning
                if(LightningUses > 0)// Om uses är mer än 0  så händer det under
                {
                    damage = 60;// gör 60 damage
                    LightningUses--;//minskar med 1 varje gång
                    Console.WriteLine($"{GetName()} använde lightning och gjorde {damage} damage, du har nu:{LightningUses} kvar");// meddelande
                }
                else 
                {
                    Console.WriteLine("Du har inga Lightnings kvar");// Om vi inte har uses kvar skriver den ut detta
                }
                break;
                
                
                default:// Om man skriver något annat än 1,2,3 så händer detta
                Console.WriteLine("Ogiltigt val");
                break; 
                
                
        }
    }
}
}