using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Game1_3 : MonoBehaviour
{
    public GameController onlySet;
    public GameObject gameOver;
    public GameObject gameClear;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("StageNum", 1));
        if (PlayerPrefs.GetInt("StageNum", 1) == 6)
        {
            explains.SetActive(true);
        }
    }

    void Update()
    {
        if (!onlySet.isInsideSet && onlySet.setFamilyList.Contains(PlayerManager.instance.gameObject.name)) gameOver.SetActive(true);

        if (onlySet.setFamilyList.Contains("ab") && onlySet.setFamilyList.Contains("Empty") && !gameOver.activeSelf) gameClear.SetActive(true);
        else gameClear.SetActive(false);
    }

    public GameObject explains;
    public GameObject[] explainImages = new GameObject[3];
    private int i = 0;

    public void PushExplainButton()
    {
        if (i == 0) explainImages[1].SetActive(true);
        else if (i == 1) explainImages[2].SetActive(true);
        else
        {
            explains.SetActive(false);
            return;
        }
        i++;
    }
}