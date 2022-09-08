using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    [SerializeField] GameObject ammoBox;
    [SerializeField] GameObject ammoDisplayPanel;

    private void OnTriggerEnter(Collider other)
    {
        GlobalAmmo.ammoCount += 7;
        ammoBox.SetActive(false);
        ammoDisplayPanel.SetActive(true);
    }
}
