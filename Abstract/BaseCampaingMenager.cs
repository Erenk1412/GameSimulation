using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    class BaseCampaingMenager : ICampaingService
    {
        public void Add(Campaings campaings)
        {
            Console.WriteLine("Campaing Added:"+campaings.CampaingName);
        }

        public void Delete(Campaings campaings)
        {
            Console.WriteLine("Campaing Deleted:"+campaings.CampaingName);
        }

        public void Update(Campaings campaings)
        {
            Console.WriteLine("Campaing Updated:"+campaings.CampaingName);
        }
    }
}
