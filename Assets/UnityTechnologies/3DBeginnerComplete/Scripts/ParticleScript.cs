using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParticleScript : MonoBehaviour
{
    public ParticleSystem particles;
    public GameObject enemy;
    public GameObject player;
    public Color lerpedColor;
    public bool nearEnemy; 
    

    // Start is called before the first frame update
    void Start()
    {
       nearEnemy = false;
    }

    // Update is called once per frame
    void Update()
    {
        lerpedColor = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 1));
        Vector3 sub = (player.transform.position - enemy.transform.position);
        var distance = Math.Sqrt(Math.Pow(sub.x, 2) + Math.Pow(sub.y, 2) + Math.Pow(sub.y, 2));
        var pMain = particles.main;
        if (nearEnemy == true)
        {
            pMain.startColor = lerpedColor;
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
        if (distance < 3)
        {
            nearEnemy = true;
            
        }
        else
        {
            nearEnemy = false;
            
        }
    }
}
