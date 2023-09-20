using Library;

namespace RoleplayGame
{
    public class Spell : IAttackItem, IDefenseItem, IMagicItem
    {
        public int AttackValue 
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
    }
}