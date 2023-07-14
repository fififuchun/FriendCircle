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
        //
    }

    void Update()
    {
        if (!onlySet.isInsideSet && onlySet.setFamilyList.Contains(PlayerManager.instance.gameObject.name)) gameOver.SetActive(true);

        if (onlySet.setFamilyList.Contains("ab") && onlySet.setFamilyList.Contains("Empty") && !gameOver.activeSelf) gameClear.SetActive(true);
        else gameClear.SetActive(false);
    }
}