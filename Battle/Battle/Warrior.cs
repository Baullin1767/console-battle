namespace Battle
{
    abstract class Warrior
    {
        protected string name;
        protected float strength;
        protected float energy;
        protected float accuracy;
        protected float evasion;
        protected float armor;
        protected float luck;
        protected float health;

        public string Name { get => name; }
        public float Strength { get => strength; }
        public float Energy { get => energy; }
        public float Accuracy { get => accuracy; }
        public float Evasion { get => evasion; }
        public float Armor { get => armor; }
        public float Luck { get => luck; }
        public float Health { get => health; }

        public virtual void Attack(Warrior opponent)
        {
            if (AttackSuccess())
            {
                float damage = strength - opponent.Armor;
                if (!opponent.DefenseSuccess())
                {
                    opponent.TakeAHit(damage);
                    Console.WriteLine($"{Name} deals {damage} damage {opponent.Name}. Health {opponent.Name}: {opponent.Health}");
                }
                else
                {
                    Console.WriteLine($"{opponent.Name} successfully defended against attack {Name}.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} missed.");
            }
        }

        protected bool AttackSuccess()
        {
            return (new Random().Next(100) < (Accuracy + Luck));
        }

        public bool DefenseSuccess()
        {
            return (new Random().Next(100) < (Evasion + Armor + Luck));
        }

        public void TakeAHit(float damage)
        {
            health -= damage;
        }
    }

}
