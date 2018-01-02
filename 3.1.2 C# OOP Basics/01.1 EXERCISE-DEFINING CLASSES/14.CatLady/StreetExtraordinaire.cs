namespace CatLady
{
    public class StreetExtraordinaire : Cat
    {
        private int decibelsOfMeows;

        public StreetExtraordinaire(string breed, string name, int decibelsOfMeows)
        {
            this.Breed = breed;
            this.Name = name;
            this.decibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.decibelsOfMeows}";
        }
    }
}
