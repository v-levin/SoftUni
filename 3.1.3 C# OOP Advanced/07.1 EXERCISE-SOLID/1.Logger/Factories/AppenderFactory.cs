using _Logger.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace _Logger.Factories
{
    public class AppenderFactory
    {
        public static IAppender GetAppender(string appenderType, ILayout layout)
        {
            Type typeOfAppender = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == appenderType);

            return (IAppender)Activator.CreateInstance(typeOfAppender, layout);
        }
    }
}
