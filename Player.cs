namespace Praktiskt_prov
{
    class Player : Character
    {
        
        private int ZapUses = 10;
        private int FireBallUses = 5;
        private int LightningUses = 2;

        private int damage = 0;

        public Player(int hp, string name) : base(hp, name) { 

        }

       public override int Attack()
        {
            
          return damage ;
        }

              public void AttackChoice(){
              
              
             
             int attackChoice = int.Parse(Console.ReadLine());
            switch (attackChoice){

                case 1: 
                if(ZapUses > 0){
                    damage = 10;
                    ZapUses--;
                    Console.WriteLine($"{GetName()} använde Zap och gjorde {damage} damage, du har nu:{ZapUses} kvar");
              
                }
                else {
                    Console.WriteLine("Du har inga Zaps kvar");
                }
                break;
                   case 2: 
                if(FireBallUses > 0){
                    damage = 20;
                    FireBallUses--;
                    Console.WriteLine($"{GetName()} använde Fireball och gjorde {damage} damage, du har nu:{FireBallUses} kvar");
                }
                else {
                    Console.WriteLine("Du har inga Fireballs kvar");
                }
                break;
                   case 3: 
                if(LightningUses > 0){
                    damage = 60;
                    LightningUses--;
                    Console.WriteLine($"{GetName()} använde lightning och gjorde {damage} damage, du har nu:{LightningUses} kvar");
                }
                else {
                    Console.WriteLine("Du har inga Lightnings kvar");
                }
                break;
                default:
                Console.WriteLine("Ogiltigt val");
                break; 
                
                
        }
    }
}
}