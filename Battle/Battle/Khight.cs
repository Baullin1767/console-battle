namespace Battle
{
    class Knight : Warrior
    {
        public Knight()
        {
            name = "Knight";
            strength = 80f;
            energy = 60f;
            accuracy = 70f;
            evasion = 50f;
            armor = 90f;
            luck = 30f;
            health = 100f;
        }
        public void MightyStrike(Warrior opponent)
        {
            float damage = Strength;
            opponent.TakeAHit(damage);
            Console.WriteLine($"{Name} uses Slam and deals {damage} damage {opponent.Name}. Health {opponent.Name}: {opponent.Health}");
        }
    }
}
