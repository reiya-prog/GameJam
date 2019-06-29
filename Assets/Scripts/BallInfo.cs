using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInfo : MonoBehaviour
{
    static private bool isOn = false;

    static public bool GetIsBallOn()
    {
        return isOn;
    }

    static public void SetIsBallOn(bool newValue)
    {
        isOn = newValue;
    }
}
