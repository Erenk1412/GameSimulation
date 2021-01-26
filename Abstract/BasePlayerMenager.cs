using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    class BasePlayerMenager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Player Deleted: "+player.FirstName);
        }

        public void Save(Player player)
        {
            Console.WriteLine("Player Saved: " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player Updated: " + player.FirstName);
        }
    }
}
