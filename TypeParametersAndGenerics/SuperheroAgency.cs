using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeParametersAndGenerics.SuperheroClasses;

namespace TypeParametersAndGenerics
{
    internal class SuperheroAgency
    {
        public List<Superhero> AllSuperheroes { get; set; } = new List<Superhero>();

        public List<Superhero> GetHeroes<T>()
        {
            List<Superhero> filteredHeroes = new List<Superhero>();
            foreach (Superhero hero in AllSuperheroes)
            {
                if (hero is T)
                {
                    filteredHeroes.Add(hero); 
                }
            }
            return filteredHeroes; 
        }

        public List<T> GetHeroesInterface<T>()
        {
            List<T> filteredHeroes = new List<T>();
            foreach (Superhero hero in AllSuperheroes)
            {
                if (hero is T heroCast)
                {
                    filteredHeroes.Add(heroCast);
                }
            }
            return filteredHeroes;
        }

    }
}
