using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entity
{
    public class Player:IEntity
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }
    }
}
