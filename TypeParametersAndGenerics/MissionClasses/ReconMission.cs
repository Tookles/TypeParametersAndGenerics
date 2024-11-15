using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics.MissionClasses
{
    internal class ReconMission<T> : Mission<T> where T : IFly
    {
        public ReconMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
