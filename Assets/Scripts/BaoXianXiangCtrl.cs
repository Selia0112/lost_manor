using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BaoXianXiangCtrl : MonoBehaviour
{
    public Transform door;
    public GameObject KeyGo;

    public Text Txt_PassWord;
    string inputStr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Txt_PassWord.text = inputStr;
    }

    public void SelectCorrect()
    {
        door.DOLocalRotate(new Vector3(0, -90, 0), 2);
        KeyGo.SetActive(true);
    }

    public void SelectError()
    {
        GameManager.Instance.isGameOver = true;
    }

    public void NumberBtnClick(int num)
    {
        inputStr += num;
    }

    public void ConfirmBtnClick()
    {
        if (inputStr.Equals("20010112"))
        {
            door.DOLocalRotate(new Vector3(0, -90, 0), 2);
            KeyGo.SetActive(true);
        }
        else
        {
            GameManager.Instance.CountDownTime -= 10;
            inputStr = null;
        }
    }

    public void DeleteBtnClick()
    {
        inputStr = null;
    }
}
