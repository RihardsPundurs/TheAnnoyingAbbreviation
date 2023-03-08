using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GraphGen : MonoBehaviour
{
    void Start()
    {
        string behindADoor = File.ReadAllText(Application.dataPath + "/BAD.json");
        Debug.Log(behindADoor);
    }
}
