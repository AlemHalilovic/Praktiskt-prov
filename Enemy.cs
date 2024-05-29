namespace Praktiskt_prov
{
    public class Enemy : Character
    {
     
        protected int Enemyhealth;
        protected int Enemydamage;


        public Enemy(int hp, string name) :  base(hp,  name) { }
        public override int Attack(){
            int damage = 5;
            Console.WriteLine($"{GetName()} skadade {damage}");
            return damage;
            }
         public void EnemyAttackChoice(){
 Random random = new Random ();
           int fiendeAttack = random.Next(1,4);
            switch (fiendeAttack)
            {

                case 1: 
                
                    Enemydamage = 5;
                   
                    Console.WriteLine($"Rat attackerade och gjorde {Enemydamage} skada");
                break;
                   case 2: 
                
                    Enemydamage = 35;
                    
                    Console.WriteLine($"Wizard attackerade och gjorde {Enemydamage} skada");
                break;
                   case 3: 
                
                    Enemydamage = 60;
                  
                    Console.WriteLine($"Giant attackerade dig och gjorde {Enemydamage} skada");
                
               
                break;
                default:
                Console.WriteLine("Ogiltigt val");
                break; 
            }
                
         }
          
            
    }  
} 



    
    
    


