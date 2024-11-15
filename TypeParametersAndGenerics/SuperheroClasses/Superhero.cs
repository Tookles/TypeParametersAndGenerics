using System.Transactions;

namespace TypeParametersAndGenerics.SuperheroClasses
{
    public class Superhero
    {
        public readonly string Alias;
        public readonly string SecretIdentity;
        public readonly int Age;
        public readonly Alignment Alignment;

        public Superhero(string alias, string secretIdentity, int age, Alignment alignment)
        {
            Alias = alias;
            SecretIdentity = secretIdentity;
            Age = age;
            Alignment = alignment;
        }
    }

    public enum Alignment
    {
        GOOD,
        EVIL
    }
}
