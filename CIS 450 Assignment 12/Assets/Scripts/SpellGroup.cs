/*
 * EJ Flores
 * Assignment 12
 * SpellGroup.cs
 * This is the group component of the spellComponent. It has the method to iterate through all members of the tree and call the Cast function on them.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellGroup : SpellComponent
{
    private List<SpellComponent> _spellComponents = new List<SpellComponent>();
    public string _name;

    public SpellGroup(string s)
    {
        _name = s;
    }

    public void Cast()
    {
        foreach(SpellComponent s in _spellComponents)
        {
            Debug.Log(s);
            s.Cast();
        }
    }

    public void Add(SpellComponent s)
    {
        _spellComponents.Add(s);
    }

    public void Remove(SpellComponent s)
    {
        _spellComponents.Remove(s);
    }

    public SpellComponent GetChild(int i)
    {
        return _spellComponents[i];
    }

    public string GetName()
    {
        return _name;
    }
}
