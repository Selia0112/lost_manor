using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyCtrl : MonoBehaviour
{
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
        if (other.CompareTag("RHand"))
        {
            if (transform.name.Equals("Key1"))
            {
                GameManager.Instance.Key1 = true;
                gameObject.SetActive(false);
            }
            if (transform.name.Equals("Key2"))
            {
                GameManager.Instance.Key2 = true;
                gameObject.SetActive(false);
            }
            if (transform.name.Equals("Key3"))
            {
                GameManager.Instance.Key3 = true;
                gameObject.SetActive(false);
            }

            if (transform.name.Equals("Key4"))
            {
                GameManager.Instance.Key4 = true;
                gameObject.SetActive(false);
            }

            if (transform.name.Equals("Key5"))
            {
                GameManager.Instance.Key5 = true;
                gameObject.SetActive(false);
            }
        }
    }
}
