using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1_1 : MonoBehaviour
{
    public GameController onlySet;
    public GameObject gameOver;
    public GameObject gameClear;

    void Start()
    {
        onlySet.isInsideSet = true;
    }

    void Update()
    {
        if (onlySet.isInsideSet) PlayerManager.instance.gameObject.transform.SetParent(onlySet.parentSet.transform);
        else gameOver.SetActive(true);

        if (onlySet.setFamilyList.Contains("a") && onlySet.setFamilyList.Contains("b")) gameClear.SetActive(true);
        else gameClear.SetActive(false);
    }
}