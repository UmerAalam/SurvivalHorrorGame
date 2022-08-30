using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    float theDistance;
    [SerializeField] GameObject openDoorText;
    [SerializeField] GameObject doorObject;
    [SerializeField] AudioSource creakSound;

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
                creakSound.Play();
            }
        }
    }
    private void OnMouseExit()
    {
      openDoorText.SetActive(false);
    }
}
