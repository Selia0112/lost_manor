using Pvr_UnitySDKAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool Key1, Key2,Key3,Key4,Key5;
    public GameObject Key1Go;

    public GameObject OpenDoorRemain;

    public GameObject TeleportPointGo;

    public GameObject GameBGIntrodecePanel;

    public Transform EndPos;
    public Transform Player;
    public bool isEscape;

    public bool isGameOver;
    public GameObject EndPanel;

    public Text Txt_CountDown;
    public float CountDownTime;
    public bool isGameStart;

    public AudioSource BGAS;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //GameBGIntrodecePanel.SetActive(true);
        TeleportPointGo.SetActive(false);
        //Invoke("CloseIntrodeceBGPanel", 10);
    }

    public void Clue1Event()
    {
        Invoke("CloseIntrodeceBGPanel", 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStart)
        {
            if (CountDownTime>0)
            {
                CountDownTime -= Time.deltaTime;
                
                Txt_CountDown.text = CountDownTime.ToString("f1");
            }
            else
            {
                isGameOver = true;
            }
          
        }

        if (Vector3.Distance(Player.position, EndPos.position) <= 5)
        {
            isEscape = true;
        }

        if (isGameOver)
        {
            EndPanel.SetActive(true);
            EndPanel.transform.GetChild(0).GetComponent<Text>().text = "You were killed by a ghost! \nPress the A key on the right-hand joystick to restart the game";
            //TeleportPointGo.SetActive(false);
            Time.timeScale = 0;

            if (Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.A))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }

        if (isEscape)
        {
          
            EndPanel.SetActive(true);
            EndPanel.transform.GetChild(0).GetComponent<Text>().text = "Congratulations, you have successfully escaped!\nPress the A key on the right-hand joystick to restart the game";

            Time.timeScale = 0;

            if (Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.A))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
    }

    public void ShowOpenDoorErrorRemain()
    {
        OpenDoorRemain.SetActive(true);
        Invoke("CloseDoorRemain", 3);
    }

    void CloseDoorRemain()
    {
        OpenDoorRemain.SetActive(false);
    }

    void CloseIntrodeceBGPanel()
    {
        //GameBGIntrodecePanel.SetActive(false);
        TeleportPointGo.SetActive(true);
        isGameStart = true;
        Key1Go.SetActive(true);
    }
}
