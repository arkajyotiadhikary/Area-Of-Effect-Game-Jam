using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioClip clip;

    public AudioSource audioSource;
    // Start is called before the first frame update
    
    public void ButtonEffect()
    {
        audioSource.PlayOneShot(clip);
    }
}
