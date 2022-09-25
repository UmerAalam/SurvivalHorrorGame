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
    [SerializeField] AudioSource line01;
    [SerializeField] AudioSource line02;

    void Start()
    {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }
    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        fadeInScreen.SetActive(false);
        line01.Play();
        textBox.GetComponent<Text>().text = "...Where am I?";
        yield return new WaitForSeconds(1.5f);
        line01.Stop();
        line02.Play();
        textBox.GetComponent<Text>().text = "I need to get out of here.";
        yield return new WaitForSeconds(2f);
        line02.Stop();
        textBox.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}
