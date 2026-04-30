using System;

namespace ClassAction
{
    public class Templar : Character
    {
        public int Strength { get; }
        public int Intelligence { get; }

        public Templar(string name, int health, int damage, int strength, int intelligence)
            : base(name, health, damage)
        {
            Strength = strength;
            Intelligence = intelligence;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Templar] (Health: {Health}, Damage: {Damage}, Strength: {Strength}, Intelligence: {Intelligence})");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" Divine Blast!");
        }
    }
}