/*
 * EJ Flores
 * Assignment 12
 * SpellComponent.cs
 * This script is the interface from which all the spell components inherit.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SpellComponent
{
    public void Cast();
    public void Add(SpellComponent s);
    public void Remove(SpellComponent s);

    public SpellComponent GetChild(int i);
    public string GetName();
}
