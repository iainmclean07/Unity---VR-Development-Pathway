using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float getHours() {
        return DateTime.Now.Hour;
    }

    public float getMinutes() {
        return DateTime.Now.Minute;
    }

    public float getSeconds() {
        return DateTime.Now.Second;
    }

}
