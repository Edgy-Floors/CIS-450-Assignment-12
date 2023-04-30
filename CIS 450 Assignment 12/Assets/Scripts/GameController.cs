using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private SpellComponent spellbook;

    // Start is called before the first frame update
    void Start()
    {
        spellbook = new SpellGroup("Spellbook");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            spellbook.Cast();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            spellbook.Add(new WaterSpell("WaterSpell"));
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpellGroup fireSpells = new SpellGroup("FireSpells");

            Fireball f = new Fireball("Fireball");
            Flamethrower fl = new Flamethrower("Flamethrower");

            fireSpells.Add(f);
            fireSpells.Add(fl);

            spellbook.Add(fireSpells);
        }
    }
}
