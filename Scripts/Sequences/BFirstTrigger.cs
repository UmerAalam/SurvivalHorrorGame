﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class BFirstTrigger : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject guideArrow;

    void OnTriggerEnter()
    {
      thePlayer.GetComponent<FirstPersonController>().enabled = false;
      StartCoroutine(ScenePlayer());
    }
    IEnumerator ScenePlayer()
    {
        textBox.GetComponent<Text>().text = "Look like a weapon on table";
        yield return new WaitForSeconds(2.5f);
        textBox.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
        guideArrow.SetActive(true);
    }

}
