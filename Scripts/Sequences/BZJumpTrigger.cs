using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    [SerializeField] AudioSource doorBang;
    [SerializeField] AudioSource doorMusic;
    [SerializeField] GameObject theDoor;
    [SerializeField] GameObject theZombie;

    void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("ZombieDoorOpen");
    }
}
