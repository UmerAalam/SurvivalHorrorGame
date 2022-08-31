using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour
{
    float theDistance;
    [SerializeField] GameObject openDoorText;
    [SerializeField] GameObject doorObject;
    [SerializeField] AudioSource audioSource;

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;  
    }
    private void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            openDoorText.SetActive(true);
        }
        if(Input.GetButtonDown("Action"))
        {
            Debug.Log("Action is Working");
            if(theDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                openDoorText.SetActive(false);
                doorObject.GetComponent<Animation>().Play("DoorFirstOpen");
                audioSource.PlayOneShot(AudioClipsController.instance.doorOpen);
            }
        }
    }
    private void OnMouseExit()
    {
      openDoorText.SetActive(false);
    }
}
