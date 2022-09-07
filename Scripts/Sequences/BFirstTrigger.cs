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
    bool isTriggered;

    private void Start()
    {
        isTriggered = true;
    }
    IEnumerator ScenePlayer()
    {
        textBox.GetComponent<Text>().text = "Look like a weapon on table";
        yield return new WaitForSeconds(2.5f);
        textBox.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
        guideArrow.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(isTriggered)
        {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
            isTriggered = false;
        }
    }

}
