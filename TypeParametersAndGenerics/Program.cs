using TypeParametersAndGenerics.MissionClasses;
using TypeParametersAndGenerics.SuperheroClasses;
using TypeParametersAndGenerics.SuperheroInterfaces;

namespace TypeParametersAndGenerics
{
    internal class Program
    {
        public static T GetLastList<T>(T[] inputArray)
        {
            //return inputArray[inputArray.Length - 1];
            return inputArray[^1];
        }

        static void Main(string[] args)
        {

            //var strandedCat = new RescueMission<IFly>("tree", 50);
            //var bugInMyCode = new RescueMission<ITech>("zoom", 1000);
            //var armWrestlingCompetition = new CombatMission<IStrength>("beach", 20);

            //var reyzhen = new Mystic("FlyGirl", "John", 30, Alignment.GOOD, 2.4, 8000.0, 5); 
            //strandedCat.HeroesDeployed.Add(reyzhen); // All good

            //var rick = new Gadgeteer("GadgetMan", "Rick", 33, Alignment.EVIL, "iPhone", 7000);

            //strandedCat.HeroesDeployed.Add(rick); // Should provide a compile time error

            //var reyzhen = new Mystic("FlyGirl", "John", 30, Alignment.GOOD, 2.4, 8000.0, 5);
            //var rich = new Gadgeteer("GadgetMan", "Rick", 33, Alignment.EVIL, "iPhone", 7000);

            //var survey1 = new ReconMission<Gadgeteer>("Leeds", 300); // Should provide an error

            //var survey2 = new ReconMission<Mystic>("Manchester", 300);

            //survey2.HeroesDeployed.Add(reyzhen); // All good
            //survey2.HeroesDeployed.Add(rich); // Should provide an error

            var myBooks = new CustomStack<string>();

            myBooks.Push("Book 1");
            myBooks.Push("Book 2");
            myBooks.Push("Book 3");

            Console.WriteLine(myBooks.Pop()); // Book 3
            //Console.WriteLine(myBooks.Count());

            foreach (var book in myBooks) 
            {
                Console.WriteLine(book);
            }
            myBooks.Count();

        }
    }
}
