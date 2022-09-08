using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    [SerializeField] GameObject ammoBox;

    private void OnTriggerEnter(Collider other)
    {
        ammoBox.SetActive(false);
    }
}
