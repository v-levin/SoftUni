﻿public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

}
