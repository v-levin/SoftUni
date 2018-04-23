using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class SoftUni : Attribute
{
    private string name;

    public SoftUni(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }
}
