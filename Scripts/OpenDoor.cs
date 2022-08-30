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
        
    }
}
