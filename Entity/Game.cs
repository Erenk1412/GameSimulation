using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entity
{
    class Game:IEntity
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }

    }
}
