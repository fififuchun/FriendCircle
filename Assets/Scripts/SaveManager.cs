using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    void Start()
    {
        Save save = new Save();
        save.clearNum = 0;

        string data = JsonUtility.ToJson(save);
        //Debug.Log(data);
    }

    void Update()
    {

    }
}

[System.Serializable]
public class Save
{
    public int clearNum;
}
