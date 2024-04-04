using Battle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choice first warrior:");
        Console.WriteLine("1. Khight");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Mage");

        string? userInput = Console.ReadLine();
        int choice1;

        while (!int.TryParse(userInput, out choice1))
        {
            Console.WriteLine("Write the number");
            userInput = Console.ReadLine();
        }

        Console.WriteLine("Choice second warrior:");
        Console.WriteLine("1. Khight");
        Console.WriteLine("2. Archer");
        Console.WriteLine("3. Mage");

        int choice2;
        userInput = Console.ReadLine();
        while (!int.TryParse(userInput, out choice2))
        {
            Console.WriteLine("Write the number");
            userInput = Console.ReadLine();
        }

        Warrior selectedWarrior1 = GetWarior(choice1);

        Warrior selectedWarrior2 = GetWarior(choice2);

        Console.WriteLine($"Battle {selectedWarrior1.Name} versus {selectedWarrior2.Name} started");

        while (selectedWarrior1.Health > 0 && selectedWarrior2.Health > 0)
        {
            Random random = new Random();
            int chance = random.Next(1, 101); // Генерирует число от 1 до 100

            Attack(chance, selectedWarrior1, selectedWarrior2);

            if (selectedWarrior2.Health > 0)
            {
                Attack(chance, selectedWarrior2, selectedWarrior1);
            }
        }

        string name = selectedWarrior1.Health > 0 ? selectedWarrior1.Name : selectedWarrior2.Name;
        Console.WriteLine($"{name} win!");
    }

    static void SpecialAttack (Warrior selectedWarrior1, Warrior selectedWarrior2)
    {
        if (selectedWarrior1 is Knight knight)
        {
            knight.MightyStrike(selectedWarrior2);
        }
        else if (selectedWarrior1 is Archer archer)
        {
            archer.PreciseShot(selectedWarrior2);
        }
        else if (selectedWarrior1 is Mage mage)
        {
            mage.Fireball(selectedWarrior2);
        }
    }

    static void Attack(int chance, Warrior selectedWarrior1, Warrior selectedWarrior2)
    {
        if (chance <= 20)
        {
            // Использование уникальной способности с вероятностью 20%

            SpecialAttack(selectedWarrior1, selectedWarrior2);
        }
        else
        {
            // Обычная атака
            selectedWarrior1.Attack(selectedWarrior2);
        }
    }

    static Warrior GetWarior(int choice)
    {
        switch(choice)
        {
            case 1:
                return new Knight();
            case 2:
                return new Archer();
            default:
                return new Mage();
        }
    }
}