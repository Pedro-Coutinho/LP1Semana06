namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health, shield;
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
            
        }
    }
}