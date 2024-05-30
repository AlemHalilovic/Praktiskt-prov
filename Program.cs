using Praktiskt_prov;// använder detta för att få tillgång till dess klasser

class Program
 {
    static void Main(string[] args)
    {
        Player hero = new Player(100, "Player");//skapar instans av soekare och fiende under
        List<Enemy> enemies = new List<Enemy>();
    
        Enemy enemy1 = new Enemy(10, "Rat");// Skapar instanser av olika fiender med olika hälsopoäng.
        Enemy enemy2 = new Enemy(20, "Wizard");
        Enemy enemy3 = new Enemy(60, "Giant");

        enemies.Add(enemy1);// Lägger till alla enemys i en lista av fiender
        enemies.Add(enemy2);
        enemies.Add(enemy3);
        ;
        Console.WriteLine("Vilken attack väljer du, 1:Zap, 2:Fireball eller 3:Lightning");// Usern väljer attack
        int attackChoice = int.Parse(Console.ReadLine());// läser av attackval och konverterar 
        hero.AttackChoice();//utför attackval

        enemy1.EnemyAttackChoice();// Utför fiendernas attack och skadar spelaren
        enemy2.EnemyAttackChoice();
        enemy3.EnemyAttackChoice();
        hero.TakeDamage(enemy1.Attack());
        hero.TakeDamage(enemy2.Attack());
        hero.TakeDamage(enemy3.Attack());

        foreach(Enemy enemy in enemies)// Loopar varje fiende i listan och tillför skada på fienden
        {
            int playerDmg = hero.Attack();//Utför spelarens attack och lagrar skada
            enemy.TakeDamage(playerDmg);//Lägger till skada på enemy

            if(enemy.GetHealth() <= 0)// Ifsats om enemy dör 
            { 
            Console.WriteLine($"Du dödade en {enemy.GetName()}");//Meddelande om enemy
            }
        
        }
            Random random = new Random ();
            int poäng = random.Next(100); //random siffra för poängen
            string filepath = "score.txt"; //filvägen där mitt resultat sparas
            using (StreamWriter sw = new StreamWriter(filepath, true)) // öppnar filen till ett tilläggsläge, using gör så att filen stängs och frigör 
            {
                sw.WriteLine($" Du har {poäng} poäng"); //Poängen
            }
    } 
  }