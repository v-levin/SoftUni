using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public Person(string name)
        {
            this.name = name;
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }

        public string Name
        {
            get { return this.name; }
        }

        public Company Company
        {
            set { this.company = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Car Car
        {
            set { this.car = value; }
        }

        public override string ToString()
        {
            var company = (this.company == null) ? "" : $"{this.company.Name} {this.company.Department} {this.company.Salary:f2}\n";
            var car = (this.car == null) ? "" : $"{this.car.Model} {this.car.Speed}\n";
            var pokemons = GetPokemonsToString();
            var parents = GetParentsToString();
            var children = GetChildrenToString();

            return $"{this.name}\n" +
                $"Company: \n{company}" +
                $"Car: \n{car}" +
                $"Pokemon: \n{pokemons}" +
                $"Parents: \n{parents}" +
                $"Children: \n{children}";
        }

        private object GetChildrenToString()
        {
            string children;
            if (this.children.Count > 0)
            {
                var childrenSb = new StringBuilder();
                foreach (var child in this.children)
                {
                    childrenSb.Append($"{child.Name} {child.Birthday}\n");
                }

                children = childrenSb.ToString().TrimEnd('\n');
            }
            else
            {
                children = string.Empty;
            }

            return children;
        }

        private object GetParentsToString()
        {
            string parents;
            if (this.parents.Count > 0)
            {
                var parentsSb = new StringBuilder();
                foreach (var parent in this.parents)
                {
                    parentsSb.Append($"{parent.Name} {parent.Birthday}\n");
                }

                parents = parentsSb.ToString();
            }
            else
            {
                parents = string.Empty;
            }

            return parents;
        }

        private string GetPokemonsToString()
        {
            string pokemons;
            if (this.pokemons.Count > 0)
            {
                var pokemonsSb = new StringBuilder();
                foreach (var pokemon in this.pokemons)
                {
                    pokemonsSb.Append($"{pokemon.Name} {pokemon.Type}\n");
                }

                pokemons = pokemonsSb.ToString();
            }
            else
            {
                pokemons = string.Empty;
            }

            return pokemons;
        }
    }
}
