using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsPlayer : MonoBehaviour
{
    Rigidbody2D rb2D;
    AudioSource audioSource;
    public AudioClip[] Clips;

    private bool IsMoving;

    private int randomTime;
    private int randomPlay;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (rb2D.velocity.x != 0 || rb2D.velocity.y != 0) IsMoving = true;

        else IsMoving = false;

        if (IsMoving && !audioSource.isPlaying) audioSource.Play();
        if (!IsMoving) audioSource.Stop();

        randomTime++;
        randomPlay = Random.Range(3000, 10000);

        if(randomTime % randomPlay == 0)
        {
            audioSource.PlayOneShot(Clips[0]);
        }
    }
}
