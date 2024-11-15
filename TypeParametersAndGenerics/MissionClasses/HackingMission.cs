using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics.MissionClasses
{
    internal class HackingMission<T> : Mission<T> where T : ITech
    {
        public HackingMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
