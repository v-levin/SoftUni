using System;
using System.Collections.Generic;
using System.Linq;
namespace CatLady
{
    public class Siamese : Cat
    {
        private int earSize;

        public Siamese(string breed, string name, int earSize)
        {
            this.Breed = breed;
            this.Name = name;
            this.earSize = earSize;
        }
        
        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.earSize}";
        }
    }
}
