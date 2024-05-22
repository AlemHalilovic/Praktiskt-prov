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

        public abstract int Attack();
    }
}