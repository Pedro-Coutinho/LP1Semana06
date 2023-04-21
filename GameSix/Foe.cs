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

        public string GetName() => name;

        public void TakeDamge(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }
    }
}