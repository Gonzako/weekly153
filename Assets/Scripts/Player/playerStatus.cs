using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStatus : MonoBehaviour
{


    [HideInInspector]
    public static bool isRolling { get; private set; }
    public static bool hasKey { get; private set; }
    public void setRolling(bool val)
    {
        isRolling = val;
    }

    public void setKey(bool val)
    {
        hasKey = val;
    }
}
