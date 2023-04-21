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
        
        }
    }
}
