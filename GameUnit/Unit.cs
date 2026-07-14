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

        public override string ToString()
        {
            // GetType().Name vai dar "SettlerUnit" ou "MilitaryUnit" dependendo do objeto real.
            // Cost:F2 garante que o float seja impresso com duas casas decimais (ex: 5.00).
            return $"{GetType().Name}: HP = {Health} COST = {Cost:F2}";
        }

    }
}
