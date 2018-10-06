using _Logger.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace _Logger.Factories
{
    public class LayoutFactory
    {
        public static ILayout GetInstance(string typeLayout)
        {
            Type layoutType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == typeLayout);

            return (ILayout)Activator.CreateInstance(layoutType);
        }
    }
}
