namespace Praktiskt_prov
{
    class Player : Character
    {
        public Player(int hp, string name) : base(hp, name) { }

        public override int Attack()
        {
            int damage = 10; 
            Console.WriteLine($"{GetName()} deals {damage} damage");
            return damage;
        }
    }
}