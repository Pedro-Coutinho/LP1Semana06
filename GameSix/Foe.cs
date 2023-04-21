namespace GameSix
{
    public class Foe
    {

        public static int powerUpTotal;
        private string name;
        private float health, shield;
        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }
        static Foe()
        {
            powerUpTotal = 0;
        }

        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;
        public static int GetPowerUpCount() => powerUpTotal;

        public void SetName(string n)
        {
            name = n.Trim();
        }

        public void TakeDamage(float damage)
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

        public void PickupPowerUp(PowerUp pw, float value)
        {
            switch (pw)
            {
                case PowerUp.Health:
                    health += value;
                    if(health > 100) health = 100;
                    break;
                case PowerUp.Shield:
                    shield += value;
                    if(shield > 100) shield = 100;
                    break;
            }
            IncreasePwCount();
        }

        private static void IncreasePwCount()
        {
            powerUpTotal++;
        }
    }
}