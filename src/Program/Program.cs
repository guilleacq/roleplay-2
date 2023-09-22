using System;
using Library;
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

            Sword sword = new Sword();
            Armor armor = new Armor();
            Staff staff = new Staff();

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.SpellsBook = book;
            gandalf.AddAttackItem(staff);

            Dwarf gimli = new Dwarf("Gimli");
            gimli.AddAttackItem(axe);
            gimli.AddDefenseItem(helmet);
            gimli.AddDefenseItem(shield);

            Knight darkknight = new Knight("Dark Knight");
            darkknight.AddAttackItem(sword);
            darkknight.AddDefenseItem(shield);
            darkknight.AddDefenseItem(armor);

            Archer santiarcher = new Archer("Santi Archer");
            santiarcher.AddAttackItem(axe);
            santiarcher.AddDefenseItem(shield);

            Console.WriteLine($"Gimli has {gimli.Health} health");
            Console.WriteLine($"Gandalf attacks Gimli and deals {gandalf.AttackValue} damage");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has {gimli.Health} health");

            gimli.Cure();

            Console.WriteLine($"Gimli has {gimli.Health} health");
        }
    }
}
