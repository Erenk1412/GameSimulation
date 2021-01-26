using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    class BaseSaleMenager : ISaleMenager
    {
        public void Sale(Player player)
        {
            Console.WriteLine("Degerli " +" "+ player.FirstName +"  "+"Oyun satın alma işleminiz başarıyla gerçekleşmiştir. İyi eğlenceler dileriz ");
        }
    }
}
