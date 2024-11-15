using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics.SuperheroClasses
{
    internal class Mystic : Superhero, IFly, ITelepathy
    {

        public double FlightSpeed { get; set; }
        public double MaxHeight { get; set; }
        public int PowerLevel { get; set; }

        public Mystic(string alias, string secretIdentity, int age, Alignment alignment, double flightSpeed, double maxHeight, int powerLevel) : base(alias, secretIdentity, age, alignment)
        {
            FlightSpeed = flightSpeed;
            MaxHeight = maxHeight;
            PowerLevel = powerLevel;
        }


    }
}
