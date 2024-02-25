using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    private string name;
    private int hunger;
    private int happiness;
    private int energy;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Hunger
    {
        get
        {
            return hunger;
        }
    }

    public int Happiness
    {
        get
        {
            return happiness;
        }
    }

    public int Energy
    {
        get
        {
            return energy;
        }
    }

    public void Eat()
    {
        if (hunger < 97)
        {
            hunger += 3;
        }
    }

    public void Rest()
    {
        if (energy < 93)
        {
            energy += 7;
        }
    }

    public void Play()
    {
        if (happiness < 95)
        {
            happiness += 5;
        }
    }

    public void GetHungry()
    {
        hunger-=5;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void GetTired()
    {
        energy-=3;
        if (energy < 0)
        {
            energy = 0;
        }
    }

    public void GetBored()
    {
        happiness-=10;
        if (happiness < 0)
        {
            happiness = 0;
        }
    }

    public Pet(string petName)
    {
        name = petName;
        hunger = 70;
        energy = 70;
        happiness = 70;
    }
}
