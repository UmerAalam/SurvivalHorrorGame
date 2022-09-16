using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour
{
    [SerializeField] AudioSource doorBang;
    [SerializeField] AudioSource doorMusic;
    [SerializeField] AudioSource ambSound;
    [SerializeField] GameObject theDoor;
    [SerializeField] GameObject theZombie;

    void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<BoxCollider>().enabled = false;
        theDoor.GetComponent<Animation>().Play("ZombieDoorOpen");
        doorBang.Play();
        theZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }
    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        ambSound.Stop();
        doorMusic.Play();
    }
}
