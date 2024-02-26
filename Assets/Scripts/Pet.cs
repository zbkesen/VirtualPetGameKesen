using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////////////////////////
//Assignment/Lab/Project: Virtual Pet
//Name: Zarek Kesen
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 02/26/2024
/////////////////////////////////////////////

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
        if (hunger < 100)
        {
            hunger += 4;
            if (hunger > 100)
            {
                hunger = 100;
            }
        }
    }

    public void Rest()
    {
        if (energy < 100)
        {
            energy += 7;
            if (energy > 100)
            {
                energy = 100;
            }
        }
    }

    public void Play()
    {
        if (happiness < 100)
        {
            happiness += 5;
            if (happiness > 100)
            {
                happiness = 100;
            }
        }
    }

    public void GetHungry()
    {
        hunger-=7;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void GetTired()
    {
        energy-=5;
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
