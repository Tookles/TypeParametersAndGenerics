using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParametersAndGenerics.MissionClasses
{
    internal class RescueMission<T> : Mission<T>
    {
        public RescueMission(string location, int reward) : base(location, reward)
        {
        }
    }
}
