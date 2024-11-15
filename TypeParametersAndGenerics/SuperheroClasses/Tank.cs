using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics.SuperheroClasses
{
    internal class Tank : Superhero, IFly, IStrength
    {
        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int StrengthLevel { get; set; }


        public Tank(string alias, string secretIdentity, int age, Alignment alignment, double flightSpeed, double maxHeight, int strengthLevel) : base(alias, secretIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            StrengthLevel = strengthLevel;
        }



    }
}
