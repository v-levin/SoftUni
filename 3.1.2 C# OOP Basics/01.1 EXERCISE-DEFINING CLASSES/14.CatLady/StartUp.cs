using System;
using System.Collections.Generic;
using System.Linq;

namespace CatLady
{
    public class StartUp
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var catParams = input.Split();
                var catBreed = catParams[0];
                var catName = catParams[1];

                Siamese siamese;
                Cymric cymric;
                StreetExtraordinaire streetExtraordinaire;
                switch (catBreed)
                {
                    case "Siamese":
                        var earSize = int.Parse(catParams[2]);
                        siamese = new Siamese(catBreed, catName, earSize);
                        cats.Add(siamese);
                        break;
                    case "Cymric":
                        var furLength = decimal.Parse(catParams[2]);
                        cymric = new Cymric(catBreed, catName, furLength);
                        cats.Add(cymric);
                        break;
                    case "StreetExtraordinaire":
                        var decibelsOfMeows = int.Parse(catParams[2]);
                        streetExtraordinaire = new StreetExtraordinaire(catBreed, catName, decibelsOfMeows);
                        cats.Add(streetExtraordinaire);
                        break;
                }
            }

            var cat = Console.ReadLine();
            var catToPrint = cats.Where(c => c.Name == cat).First();

            Console.WriteLine(catToPrint.ToString());
        }
    }
}
