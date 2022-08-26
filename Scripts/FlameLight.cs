using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameLight : MonoBehaviour
{
    private int lightMode;
    [SerializeField] GameObject flameLight;

    private void Update()
    {
        if (lightMode == 0)
            StartCoroutine(AnimateLight());
    }
    IEnumerator AnimateLight()
    {
        lightMode = Random.Range(1,4);
        if (lightMode == 1)
            flameLight.GetComponent<Animation>().Play("TorchAnimation1");
        if (lightMode == 2)
            flameLight.GetComponent<Animation>().Play("TorchAnimation2");
        if (lightMode == 3)
            flameLight.GetComponent<Animation>().Play("TorchAnimation3");
        yield return new WaitForSeconds(0.99f);
        lightMode = 0;
    }
}
