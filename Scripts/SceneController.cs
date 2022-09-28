using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] Animation logo;
    [SerializeField] Animation horrorGameText;

    private void Awake()
    {
        StartCoroutine(SplashScreen());
    }
    public IEnumerator SplashScreen()
    {
        logo.Play("Intro");
        horrorGameText.Play("IntroHorrorGame");
        yield return new WaitForSeconds(3f);
        logo.Play("Outro");
        horrorGameText.Play("OutroHorrorGame");
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene("Main_Menu");
    }
}
