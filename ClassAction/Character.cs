using System;

namespace ClassAction
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Damage { get; }

        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public abstract void Describe();

        public virtual void Attack()
        {
            Console.Write("Attack:");
        }
    }
}