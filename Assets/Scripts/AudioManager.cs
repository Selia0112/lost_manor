﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SoundAS;
    public AudioClip[] RandomClips;

    public AudioSource BGAS;

    float timer = 0;
    float IntervalTime=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        //if (timer>=IntervalTime)
        //{
        //    timer = 0;
        //    IntervalTime = Random.Range(18, 35);
        //    SoundAS.PlayOneShot(RandomClips[Random.Range(0, RandomClips.Length)]);
        //}

        if (GameManager.Instance.isGameStart&&!GameManager.Instance.isGameOver)
        {
            BGAS.enabled = true;
        }

        if (GameManager.Instance.isEscape)
        {
            BGAS.enabled = false;
        }
     
     

        if (GameManager.Instance.isGameOver&& BGAS.enabled)
        {
            SoundAS.PlayOneShot(RandomClips[0]);
            BGAS.enabled = false;
        }
    }
}
