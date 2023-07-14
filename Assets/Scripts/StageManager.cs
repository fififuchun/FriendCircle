using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public void Push1_1Button()
    {
        SceneManager.LoadScene("STAGE1_1");
    }

    public void Push1_2Button()
    {
        SceneManager.LoadScene("STAGE1_2");
    }

    public void Push1_3Button()
    {
        SceneManager.LoadScene("STAGE1_3");
    }

    public void Push1_4Button()
    {
        SceneManager.LoadScene("STAGE1_4");
    }

    public void Push1_5Button()
    {
        SceneManager.LoadScene("STAGE1_5");
    }

    public void Push1_6Button()
    {
        SceneManager.LoadScene("STAGE1_6");
    }

    public void Push1_7Button()
    {
        SceneManager.LoadScene("STAGE1_7");
    }

    public void Push1_8Button()
    {
        SceneManager.LoadScene("STAGE1_8");
    }

    public void Push1_9Button()
    {
        SceneManager.LoadScene("STAGE1_9");
    }

    public void Push0_1Button()
    {
        SceneManager.LoadScene("STAGE0_1");
    }

    public void Push0_2Button()
    {
        SceneManager.LoadScene("STAGE0_2");
    }

    public void Push0_3Button()
    {
        SceneManager.LoadScene("STAGE0_3");
    }

    public void PushTestButton()
    {
        SceneManager.LoadScene("STAGE1_2 1");
    }

    public void PushResetButton()
    {
        PlayerPrefs.SetInt("StageNum", 1);
        Start();
    }

    public Button[] stageButtons = new Button[12];
    public Image[] lockImages = new Image[12];

    private int stageNum;
    //初期状態は1です、0_1クリアで2になります、以下同様

    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            //これ必要？？
            stageButtons[i].enabled = false;
            lockImages[i].enabled = true;
        }
        stageNum = PlayerPrefs.GetInt("StageNum", 1);

        for (int i = 0; i < stageNum; i++)
        {
            stageButtons[i].enabled = true;
            lockImages[i].enabled = false;
        }
    }
}
