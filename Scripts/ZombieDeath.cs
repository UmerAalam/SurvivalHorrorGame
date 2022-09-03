using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    [SerializeField] int enemyHealth = 5;
    [SerializeField] GameObject theEnemy;
    int statusCheck = 0;
    private void Start()
    {
        Debug.Log(statusCheck);
        theEnemy.GetComponent<Animation>().Play("Walk");
    }
    public void ZombieKilled(int damageAmount)
    {
        enemyHealth -= damageAmount;
        Debug.Log(enemyHealth);
    }
    void Update()
    {
        if(enemyHealth <= 0 && statusCheck == 0)
        {
            Debug.Log("Hit a Bullet Enemy!");
            statusCheck = 2;
            theEnemy.GetComponent<Animation>().Stop("Walk");
            theEnemy.GetComponent<Animation>().Play("ZombieDeath");
        }
    }
}
