using System;
using Library;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IAttackItem axe = new Axe();
            IDefenseItem helmet = new Helmet();
            IDefenseItem shield = new Shield();

            IAttackItem sword = new Sword();
            IDefenseItem armor = new Armor();

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.AddAttackItem(axe);
            gimli.AddDefenseItem(helmet);
            gimli.AddDefenseItem(shield);

            Knight darkknight = new Knight("Dark Knight");
            darkknight.AddAttackItem(sword);
            darkknight.AddDefenseItem(shield);
            darkknight.AddDefenseItem(armor);


            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
