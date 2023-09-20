using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.AddAttackItem(axe);
            gimli.AddDefenseItem(helmet);
            gimli.AddDefenseItem(shield);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
