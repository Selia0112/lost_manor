using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DrawCtrl : MonoBehaviour
{
    public Vector3 EndPos;
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
        if (other.CompareTag("RHand") )
        {
            transform.DOLocalMove(EndPos, 2);
        }
    }
}
