namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(): base(1,3)
        {
            // vazio
        }
        public override float Cost => 5;
    }
}