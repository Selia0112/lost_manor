﻿using HighlightingSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue1Ctrl : MonoBehaviour
{
    public GameObject ClueRemainGo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RHand") && GetComponent<Highlighter>().tween)
        {
            ClueRemainGo.SetActive(true);
            GetComponent<Highlighter>().tween = false;
            GameManager.Instance.Clue1Event();
        }
    }
}
