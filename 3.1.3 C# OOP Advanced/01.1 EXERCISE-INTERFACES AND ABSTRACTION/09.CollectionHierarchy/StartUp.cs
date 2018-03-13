using CollectionHierarchy.Entities;
using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            IAddCollection<string> addCollection = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();

            var itemsToAdd = Console.ReadLine().Split();
            var removeOperationsCount = int.Parse(Console.ReadLine());

            var addCollectionAddIndexes = new StringBuilder();
            var addRemoveCollectionAddIndexes = new StringBuilder();
            var myListAddIndexes = new StringBuilder();

            foreach (var item in itemsToAdd)
            {
                addCollectionAddIndexes.Append($"{addCollection.Add(item)} ");
                addRemoveCollectionAddIndexes.Append($"{addRemoveCollection.Add(item)} ");
                myListAddIndexes.Append($"{myList.Add(item)} ");
            }

            var addRemoveCollectionRemoveElements = new StringBuilder();
            var myListRemoveElements = new StringBuilder();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                addRemoveCollectionRemoveElements.Append($"{addRemoveCollection.Remove()} ");
                myListRemoveElements.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addCollectionAddIndexes.ToString().Trim());
            Console.WriteLine(addRemoveCollectionAddIndexes.ToString().Trim());
            Console.WriteLine(myListAddIndexes.ToString().Trim());

            Console.WriteLine(addRemoveCollectionRemoveElements.ToString().Trim());
            Console.WriteLine(myListRemoveElements.ToString().Trim());
        }
    }
}
