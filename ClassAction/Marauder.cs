using System;

namespace ClassAction
{
    public class Marauder : Character
    {
        public int Strength { get; }

        public Marauder(string name, int health, int damage, int strength)
            : base(name, health, damage)
        {
            Strength = strength;
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} [Marauder] (Health: {Health}, Damage: {Damage}, Strength: {Strength})");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine(" Earthquake!");
        }
    }
}