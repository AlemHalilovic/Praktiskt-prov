namespace Praktiskt_prov
{
    class Enemy : Character
    {
     
        private int health;
        private int damage;


        public Enemy(int hp, string name) :  base(hp,  name) { }
        public override int Attack(){
            int damage = 5;
            Console.WriteLine($"{GetName()} skadade {damage}");
            return damage;

            
        }
    }
    


    
}