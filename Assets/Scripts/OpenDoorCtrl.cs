using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum DoorType
{
    DoorType1,
    DoorType2,
    DoorType3,
    DoorType4,
    DoorType5
}

public class OpenDoorCtrl : MonoBehaviour
{
    public Vector3 OpenDoorAngle;
    public DoorType doorType;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RHand"))
        {
            if (doorType==DoorType.DoorType1&&GameManager.Instance.Key1)
            {              
                GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audios/开门声"));
                transform.DOLocalRotate(OpenDoorAngle, 2).OnComplete(() =>
                {
                   
                });
            }
            else if (doorType == DoorType.DoorType2 && GameManager.Instance.Key2)
            {             
                GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audios/开门声"));
                transform.DOLocalRotate(OpenDoorAngle, 2).OnComplete(() =>
                {

                });
            }
            else if (doorType == DoorType.DoorType3 && GameManager.Instance.Key3)
            {
                GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audios/开门声"));
                transform.DOLocalRotate(OpenDoorAngle, 2).OnComplete(() =>
                {

                });
            }
            else if (doorType == DoorType.DoorType4 && GameManager.Instance.Key4)
            {
                GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audios/开门声"));
                transform.DOLocalRotate(OpenDoorAngle, 2).OnComplete(() =>
                {

                });
            }
            else if (doorType == DoorType.DoorType5 && GameManager.Instance.Key5)
            {
                GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audios/开门声"));
                transform.DOLocalRotate(OpenDoorAngle, 2).OnComplete(() =>
                {

                });
            }
            else
            {
                GameManager.Instance.ShowOpenDoorErrorRemain();
            }           
        }
    }
}
