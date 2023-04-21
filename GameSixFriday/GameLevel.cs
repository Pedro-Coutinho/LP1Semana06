using System;

namespace GameSixFriday
{
    public class GameLevel
    {   
        Difficulty difficulty;
        Foe[] rooms;
        public GameLevel(int nRooms, Difficulty diff)
        {
            rooms = new Foe[nRooms];
            difficulty = diff;
        }

        public Difficulty GetDifficulty()=>difficulty;
        public int GetNumRooms()=> rooms.Length;

        public int GetNumFoes()
        {
            int nFoes = 0;

            foreach(Foe f in rooms)
            {
                if(f != null) nFoes++;
            }

            return nFoes;
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            if(rooms[room] != null) Console.WriteLine("Room already has a foe");
            else rooms[room] = foe;
        }

        public void PrintFoes()
        {
            for(int i = 0; i< rooms.Length; i++)
            {
                if(rooms[i]!= null)
                {
                    Console.WriteLine($"Room {i}: {rooms[i].GetName()}");
                }

            }
        }
    }
}