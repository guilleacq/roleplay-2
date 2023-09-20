using Library;

namespace RoleplayGame
{
    public class Staff : IAttackItem, IDefenseItem, IMagicItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}