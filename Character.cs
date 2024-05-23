namespace Praktiskt_prov
{
    abstract class Character
    {
        protected int Hp;
        private string Name;

        public Character(int hp, string name)
        {
            this.Hp = hp;
            this.Name = name;
        }

        public void SetHealth(int value)
        {
            Hp = value;
        }
        
        public string GetName()
        {
            return Name;
        }
        public int GetHealth()
        {
            return Hp;
        } 
        public void TakeDamage(int damage){
            Hp -= damage;
            Console.WriteLine($"{Name} tog {damage} skada och har nu bara {Hp} hp kvar");
            if (Hp <= 0){
                Console.WriteLine($"{Name} dog :(");
            }
        }

        public abstract int Attack();
    }
}