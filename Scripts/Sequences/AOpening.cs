using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AOpening : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject fadeInScreen;
    [SerializeField] GameObject textBox;

    void Start()
    {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }
    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        fadeInScreen.SetActive(false);
        textBox.GetComponent<Text>().text = "I need to get out of here.";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}
