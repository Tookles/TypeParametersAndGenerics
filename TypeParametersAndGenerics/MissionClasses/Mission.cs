using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParametersAndGenerics.MissionClasses
{
    internal abstract class Mission<T>
    {
        public string Location { get; private set; }

        public int Reward { get; private set; }

        public List<T> HeroesDeployed { get; set; } = new List<T>();

        public Mission(string location, int reward)
        {
            Location = location;
            Reward = reward;
        }


    }
}
