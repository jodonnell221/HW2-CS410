using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NearAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public GameObject player;
    public GameObject exitLoc;
    public bool audioPlayed; 
    // Start is called before the first frame update
    void Start()
    {
        audioPlayed = false; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sub = (player.transform.position - exitLoc.transform.position);
        var distance = Math.Sqrt(Math.Pow(sub.x, 2) + Math.Pow(sub.y, 2) + Math.Pow(sub.y, 2));


        if (distance < 10)
        {
            if (audioPlayed == false)
            {
                source.PlayOneShot(clip);
                audioPlayed = true; 
            }
        }
        else
        {
            audioPlayed = false;
        }

    }
}
