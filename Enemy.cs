namespace Praktiskt_prov
{
    public class Enemy : Character //Fiende klass och ärver från character
    {
     
        protected int Enemyhealth; // Skyddar för att bevara fiendens hp och skada 
        protected int Enemydamage;
      

        public Enemy(int hp, string name) :  base(hp,  name) //Konstruktor som initierar hp,namn och anropar basklassens konstruktor
        {

        } 
        public override int Attack()// överskrider abstrakta klassens metod Attack från basklass
        { 
            int damage = 5;// Visar hur mycket skada den gör
            Console.WriteLine($"{GetName()} skadade {damage}");//Skriver ut namn och hur mycket den skadade
            return damage;//returnerar damage
        }

        public void EnemyAttackChoice()//Metod för vilken fiende som ska attackera (Slumpmässigt)
        {

           Random random = new Random ();//Skapar instans
           int fiendeAttack = random.Next(1,4);//Väljer en siffra 

            switch (fiendeAttack) //Väljer vilken attack som ska utföras baserat på förra talet
            {

                 case 1: // Om Rat attackerar 
                    Enemydamage = 5;//Hur mycket skada den gör
                    Console.WriteLine($"Rat attackerade dig och gjorde {Enemydamage} skada");//Skriver ut vem som attackerade och hur mycket skada
                break;//Avslutar och hoppar ut ur switchen

                 case 2: //Om Wizard attackerar 
                    Enemydamage = 35;
                    Console.WriteLine($"Wizard attackerade dig och gjorde {Enemydamage} skada");
                break;

                 case 3: //Om Giant attackerar
                    Enemydamage = 50;
                    Console.WriteLine($"Giant attackerade dig och gjorde {Enemydamage} skada");
                break;


                default:
                Console.WriteLine("Ingen attackerade");//Vad som händer om ingen attackerar
                break; 
            }
                
         }
          
            
    }  
} 



    
    
    


