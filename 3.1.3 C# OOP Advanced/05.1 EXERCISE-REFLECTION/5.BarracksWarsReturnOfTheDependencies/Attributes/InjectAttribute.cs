using System;

namespace BarracksWarsReturnOfTheDependencies.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class InjectAttribute : Attribute
    {
    }
}
