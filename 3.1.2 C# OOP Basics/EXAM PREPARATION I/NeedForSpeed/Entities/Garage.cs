using System;
using System.Collections.Generic;

public class Garage
{
    private List<int> parkedCars;

    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public List<int> ParkedCars
    {
        get { return this.parkedCars; }
        protected set { this.parkedCars = value; }
    }

    public void AddCar(int id)
    {
        this.ParkedCars.Add(id);
    }

    internal void RemoveCar(int id)
    {
        this.ParkedCars.Remove(id);
    }
}
