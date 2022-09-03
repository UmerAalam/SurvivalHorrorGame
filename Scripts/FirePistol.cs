using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    [SerializeField] GameObject theGun;
    [SerializeField] GameObject muzzleFlash;
    [SerializeField] AudioSource shootSound;
    [SerializeField] int damageAmount = 5;
    float targetDistance;
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
        RaycastHit shoot;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out shoot))
        {
            targetDistance = shoot.distance;
            shoot.transform.SendMessage("ZombieKilled",damageAmount,SendMessageOptions.DontRequireReceiver);
            Debug.Log("Shoot a bullet Enemy!");
        }
        isFiring = true;
        theGun.GetComponent<Animation>().Play("Shoot");
        muzzleFlash.SetActive(true);
        muzzleFlash.GetComponent<Animation>().Play("MuzzleFlash");
        shootSound.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
}
