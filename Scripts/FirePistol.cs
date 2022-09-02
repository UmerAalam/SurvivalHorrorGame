using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    [SerializeField] GameObject theGun;
    [SerializeField] GameObject muzzleFlash;
    [SerializeField] AudioSource shoot;
    bool isFiring = false;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(isFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {
        isFiring = true;
        theGun.GetComponent<Animation>().Play("Shoot");
        muzzleFlash.SetActive(true);
    }
}
