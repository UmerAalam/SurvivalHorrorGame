using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        StartCoroutine(SplashScreen());
    }
    public IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main_Menu");
    }
}
