using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    interface IPlayerService
    {
        void Save(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
