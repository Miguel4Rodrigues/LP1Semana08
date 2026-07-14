namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; set; }
        public int XP { get; set; }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
        public override int Health 
        { 
            get => base.Health; 
            set => base.Health = value + XP; 
        }
        public override float Cost => AttackPower + XP;

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP = {AttackPower} XP = {XP}";
        }

    }
}