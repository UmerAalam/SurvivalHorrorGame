using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipsController : MonoBehaviour
{
    public static AudioClipsController instance;
    public AudioClip doorOpen;

    private void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
}
