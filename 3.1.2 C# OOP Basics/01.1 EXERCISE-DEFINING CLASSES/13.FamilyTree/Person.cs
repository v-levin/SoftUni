using System.Collections.Generic;

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.parents = new List<Person>();
        this.children = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
    }

    public List<Person> Children
    {
        get { return this.children; }
    }
}

