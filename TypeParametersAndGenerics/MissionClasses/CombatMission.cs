using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParametersAndGenerics.MissionClasses
{
    internal class CombatMission<T> : Mission<T>
    {
        public CombatMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
