﻿using System;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Model { get; }

    public string Color { get; }

    public int Battery { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Baterries" +
            $"{Environment.NewLine}" +
            $"{this.Start()}" +
            $"{Environment.NewLine}" +
            $"{this.Stop()}";
    }
}
