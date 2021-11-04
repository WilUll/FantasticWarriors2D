using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip [] Clips;

    private int randomTime;
    private int randomPlay;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        randomTime++;
        randomPlay = 1000;

        int randomIndex = Random.Range(0, 7);

        if (randomTime % randomPlay == 0)
        {
            audioSource.PlayOneShot(Clips[randomIndex]);
        }
    }
}
