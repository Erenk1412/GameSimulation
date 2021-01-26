using GameSimulation.Abstract;
using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concerte
{
    class PlayerCheckMenager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            
            Console.WriteLine(player.FirstName +"  "+"isimli oyuncunun bilgileri doğrulandı");
            return true;
        }
    }
}
