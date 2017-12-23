using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name, int badges, List<Pokemon> pokemons)
    {
        this.name = name;
        this.badges = badges;
        this.pokemons = pokemons;
    }

    public string Name
    {
        get { return this.name; }
    }

    public int Badges
    {
        get { return this.badges; }
        set { this.badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
    }
}
