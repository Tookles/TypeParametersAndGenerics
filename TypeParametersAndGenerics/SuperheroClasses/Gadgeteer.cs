using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics.SuperheroClasses
{
    internal class Gadgeteer : Superhero, ITech, IStrength
    {
        public string Gadget { get; set; }

        public int StrengthLevel { get; set; }

        public Gadgeteer(string alias, string secretIdentity, int age, Alignment alignment, string gadget, int strengthLevel) : base(alias, secretIdentity, age, alignment)
        {
            Gadget = gadget;
            StrengthLevel = strengthLevel;
        }
    }
}
