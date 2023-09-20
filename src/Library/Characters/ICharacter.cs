
namespace Library
{
    public interface ICharacter
    {
        public string Name {get; set;}
        public int AttackValue{ get;} 
        public int DefenseValue {get;}
        public int Health {get;}
        public void ReceiveAttack(int power);
        public void Cure();

    }
}