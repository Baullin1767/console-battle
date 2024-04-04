namespace Battle
{
    class Mage : Warrior
    {
        public Mage()
        {
            name = "Mage";
            strength = 60f;
            energy = 100f;
            accuracy = 80f;
            evasion = 70f;
            armor = 30f;
            luck = 60f;
            health = 70f;
        }
        public void Fireball(Warrior opponent)
        {
            float damage = Strength + 10; // Увеличенный урон
            opponent.TakeAHit(damage);
            Console.WriteLine($"{Name} uses Fireball and deals {damage} damage {opponent.Name}. Health {opponent.Name}: {opponent.Health}");
        }

    }
}
