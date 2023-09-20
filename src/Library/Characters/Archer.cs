using Library;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Archer : ICharacter
    {
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        private List<IAttackItem> attackItems;
        private List<IDefenseItem> defenseItems;
        public int AttackValue
        {
            get
            {
                int attack = 0;
                foreach (var item in attackItems)
                {
                    attack += item.AttackValue;
                }
                return attack;
            }
        }

        public int DefenseValue
        {
            get
            {
                int defense = 0;
                foreach (var item in defenseItems)
                {
                    defense += item.DefenseValue;
                }

                return defense;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddDefenseItem(IDefenseItem item)
        {
            defenseItems.Add(item);
        }

        public void AddAttackItem(IAttackItem item)
        {
            attackItems.Add(item);
        }
    }
}