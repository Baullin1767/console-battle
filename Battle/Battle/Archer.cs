namespace Battle
{
    class Archer : Warrior
    {
        public Archer()
        {
            name = "Archer";
            strength = 70f;
            energy = 80f;
            accuracy = 90f;
            evasion = 60f;
            armor = 40f;
            luck = 50f;
            health = 80f;
        }
        public void PreciseShot(Warrior opponent)
        {
            float damage = Strength + 20; // Увеличенный урон
            opponent.TakeAHit(damage);
            Console.WriteLine($"{Name} uses Precision Shot and deals {damage} damage {opponent.Name}. Health {opponent.Name}: {opponent.Health}");
        }
    }
}
