using Praktiskt_prov;

class Program
{
    static void Main(string[] args)
    {
        Player hero = new Player(100, "Player");

        List<Enemy> enemies = new List<Enemy>();

        Enemy enemy1 = new Enemy(10, "Rat");
          Enemy enemy2 = new Enemy(20, "Wizard");
            Enemy enemy3 = new Enemy(60, "Giant");
        enemies.Add(enemy1);
          enemies.Add(enemy2);
            enemies.Add(enemy3);

        ;
      
      
             Console.WriteLine("Vilken attack väljer du, 1:Zap, 2:Fireball eller 3:Lightning");
             int attackChoice = int.Parse(Console.ReadLine());
             hero.AttackChoice();
             enemy1.EnemyAttackChoice();
             enemy2.EnemyAttackChoice();
             enemy3.EnemyAttackChoice();
      

        
        foreach(Enemy enemy in enemies){
             int playerDmg = hero.Attack();
        enemy.TakeDamage(playerDmg);
         if(enemy.GetHealth() <= 0){
        Console.WriteLine($"Du dödade en {enemy.GetName()}");

      }

     
        

        
    }

}}