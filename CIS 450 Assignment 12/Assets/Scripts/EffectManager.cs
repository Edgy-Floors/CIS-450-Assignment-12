/*
 * EJ Flores
 * Assignment 12
 * EffectManager.cs
 * This script controls the effects for all the components.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance;

    public GameObject fireProjectile;
    public GameObject waterProjectile;
    public GameObject flamethrowerProjectile;
    public Transform player;


    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void Awake()
    {
        instance = this;
    }

    public void spawnFireProjectile()
    {
        Instantiate(fireProjectile, player.transform.position, Quaternion.identity);
    }

    public void spawnWaterProjectile()
    {
        Instantiate(waterProjectile, player.transform.position, Quaternion.identity);
    }

    public void spawnFlamethrowerProjectile()
    {
        Instantiate(flamethrowerProjectile, player.transform.position, Quaternion.identity);
        Instantiate(flamethrowerProjectile, player.transform.position, Quaternion.identity);
        Instantiate(flamethrowerProjectile, player.transform.position, Quaternion.identity);
        Instantiate(flamethrowerProjectile, player.transform.position, Quaternion.identity);
        Instantiate(flamethrowerProjectile, player.transform.position, Quaternion.identity);
    }
}
