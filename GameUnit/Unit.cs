using System;

namespace GameUnit
{
    public abstract class Unit
    {
        public int Movement { get; set;}
        public virtual int Health { get; set; }
        public  abstract float Cost { get; }
        public Unit(int movement, int health)
        {
            Movement = movement;
            Health = health;
        }
        public void Move()
        {
            Console.WriteLine($"Moved: {ToRoman(Movement)}");
        }
        private string ToRoman(int number)
        {
            string[] roman = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            return roman[number - 1];
        }        
    }
}
