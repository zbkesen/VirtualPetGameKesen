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
        hunger++;
    }

    public void Rest()
    {
        energy++;
    }

    public void Play()
    {
        happiness++;
    }

    public void GetHungry()
    {
        hunger-=5;
    }

    public void GetTired()
    {
        energy-=5;
    }

    public void GetBored()
    {
        happiness-=5;
    }

    public Pet(string petName)
    {
        name = petName;
        hunger = 100;
        energy = 100;
        happiness = 100;
    }
}
