﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public static ZombieDeath instance;
    [SerializeField] int enemyHealth = 5;
    [SerializeField] GameObject theEnemy;
    [SerializeField] AudioSource ambSound;
    [SerializeField] AudioSource jumpScareSound;
    int statusCheck = 0;
    private void Start()
    {
        statusCheck = 0;
        instance = this;
    }
    public void ZombieKilled(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
    void Update()
    {
        if(enemyHealth <= 0 && statusCheck == 0)
        {
            statusCheck = 2;
            GetComponent<ZombieAI>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            theEnemy.GetComponent<Animation>().Stop("Walk");
            theEnemy.GetComponent<Animation>().Stop("ZombieScream");
            theEnemy.GetComponent<Animation>().Play("ZombieDeath");
            jumpScareSound.Stop();
            ambSound.Play();
        }
    }
}
