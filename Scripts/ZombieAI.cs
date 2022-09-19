using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject theEnemy;
    [SerializeField] GameObject flash;
    [SerializeField] float enemySpeed = 0.04f;
    [SerializeField] AudioSource[] hurtSounds;
    bool attackTrigger = false;
    bool isAttacking = false;

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.04f;
            theEnemy.GetComponent<Animation>().Play("Walk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("ZombieScream");
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        attackTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            attackTrigger = false;
    }


    IEnumerator InflictDamage()
    {
        isAttacking = true;
        hurtSounds[Random.Range(0, hurtSounds.Length)].Play();
        flash.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        flash.SetActive(false);
        yield return new WaitForSeconds(0.7f);
        GlobalHealth.currentHealth -= 5;
        Debug.Log(GlobalHealth.currentHealth);
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;
    }
}
