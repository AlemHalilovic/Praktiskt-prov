using Praktiskt_prov;

class Program
{
    static void Main(string[] args)
    {
        Player hero = new Player(100, "Player");

        List<Enemy> enemies = new List<Enemy>{
            new Enemy(20,"Wizard"),
            new Enemy(10,"Rat"),
            new Enemy(60,"Giant")
        };
      
      
             Console.WriteLine("Vilken attack väljer du, 1:Zap, 2:Fireball eller 3:Lightning");
             int attackChoice = int.Parse(Console.ReadLine());
             hero.AttackChoice();
      
      
      
      
      
      
      
      
      
      
        

        
        foreach(Enemy enemy in enemies){
             int playerDmg = hero.Attack();
        enemy.TakeDamage(playerDmg);

         if(enemy.GetHealth() <= 0){
        Console.WriteLine($"Du dödade en {enemy.GetName()}");

      }

     
        

        
    }

}}