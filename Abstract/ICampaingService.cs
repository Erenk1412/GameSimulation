using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    interface ICampaingService
    {
        void Add(Campaings campaings);
        void Delete(Campaings campaings);
        void Update(Campaings campaings);

    }
}
