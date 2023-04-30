/*
 * EJ Flores
 * Assignment 12
 * Flamethrower.cs
 * This script is the leaf of the spell component, shown as a flamethrower.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : SpellComponent
{
    private string _name;

    public Flamethrower(string name)
    {
        _name = name;
    }

    public void Cast()
    {
        EffectManager.instance.spawnFlamethrowerProjectile();
    }

    public void Add(SpellComponent s)
    {
        Debug.LogWarning("Cannot add anything to a singular spell.");
    }

    public void Remove(SpellComponent s)
    {
        Debug.LogWarning("Cannot remove anything from a singular spell.");
    }

    public SpellComponent GetChild(int i)
    {
        Debug.Log("A singular spell does not have a child.");
        return null;
    }

    public string GetName()
    {
        return _name;
    }
}
