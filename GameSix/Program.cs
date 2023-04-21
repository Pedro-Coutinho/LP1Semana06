using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of enemies:");
            int nEnemies = 0;
            bool validInput = false;
            do
            {
                validInput = Int32.TryParse(Console.ReadLine(), out nEnemies);
                if(!validInput) Console.WriteLine("Invalid input!");
            }
            while (!validInput);

            Foe[] enemies = new Foe[nEnemies];
            for(int i = 0; i< nEnemies; i++)
            {
                Console.WriteLine("Enemie name?");
                string name = Console.ReadLine();
                enemies[i] = new Foe(name);
            }  

            foreach(Foe foe in enemies)
            {
                string n = foe.GetName();
                Console.WriteLine(n);
            }

            Random rnd = new Random();
            foreach(Foe foe in enemies)
            {
                int pw = rnd.Next(2);
                PowerUp powerUp;
                if(pw == 0) powerUp = PowerUp.Health;
                else powerUp = PowerUp.Shield;

                foe.PickupPowerUp(powerUp, rnd.Next(16));

                foe.TakeDamage(rnd.Next(20));

                Console.WriteLine($"Health:{foe.GetHealth()}, Shield:{foe.GetShield()}");
            }
        
        }
    }
}
