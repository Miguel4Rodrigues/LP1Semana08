using System;

namespace ClassAction
{
    public class Witch : Character
    {
        public int Intelligence { get; }

        public Witch(string name, int health, int damage, int intelligence)
            : base(name, health, damage)
        {
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Witch] (Health: {Health}, Damage: {Damage}, Intelligence: {Intelligence})");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" Essence Drain!");
        }
    }
}