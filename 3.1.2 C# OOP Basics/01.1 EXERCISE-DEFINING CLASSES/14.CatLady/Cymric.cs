namespace CatLady
{
    public class Cymric : Cat
    {
        private decimal furLength;

        public Cymric(string breed, string name, decimal furLength)
        {
            this.Breed = breed;
            this.Name = name;
            this.furLength = furLength;
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.furLength:F2}";
        }
    }
}
