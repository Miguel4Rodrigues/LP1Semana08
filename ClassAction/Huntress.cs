using System;

namespace ClassAction
{
    public class Huntress : Character
    {
        public int Dexterity { get; }

        public Huntress(string name, int health, int damage, int dexterity)
            : base(name, health, damage)
        {
            Dexterity = dexterity;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Huntress] (Health: {Health}, Damage: {Damage}, Dexterity: {Dexterity})");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" Fangs of Frost!");
        }
    }
}