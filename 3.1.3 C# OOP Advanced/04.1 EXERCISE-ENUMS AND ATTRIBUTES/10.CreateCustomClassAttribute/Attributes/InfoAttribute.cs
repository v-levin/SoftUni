using System;
using System.Collections.Generic;

namespace CreateCustomClassAttribute.Attributes
{
    public class InfoAttribute : Attribute
    {
        public InfoAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = new List<string>(reviewers);
        }

        public string Author { get; set; }

        public int Revision { get; set; }

        public string Description { get; set; }

        public IList<string> Reviewers { get; set; }
        
        
        public void PrintInfo(string input)
        {
            switch (input)
            {
                case "Author":
                    Console.WriteLine($"Author: {this.Author}");
                    break;
                case "Revision":
                    Console.WriteLine($"Revision: {this.Revision}");
                    break;
                case "Description":
                    Console.WriteLine($"Description: {this.Description}");
                    break;
                case "Reviewers":
                    Console.WriteLine($"Reviewers: {string.Join(", ",this.Reviewers)}");
                    break;
                default:
                    break;
            }
        }
    }
}
