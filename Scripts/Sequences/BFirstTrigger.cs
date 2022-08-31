using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class BFirstTrigger : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject guideArrow;
    bool isTrigger;

    private void Start()
    {
        isTrigger = true;
    }
    IEnumerator ScenePlayer()
    {
        Debug.Log("I called ScenePlayer Function!");
        textBox.GetComponent<Text>().text = "Look like a weapon on table";
        yield return new WaitForSeconds(2.5f);
        textBox.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
        guideArrow.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(isTrigger)
        {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
            isTrigger = false;
        }
    }

}
