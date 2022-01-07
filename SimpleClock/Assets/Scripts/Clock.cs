using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private const float hourToDegrees = -30.0f;
    private const float minuteToDegrees = -6.0f;
    private const float secondToDegrees = -6.0f;
    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;
    
    private void FixedUpdate()
    {
        TimeSpan currentTime = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hourToDegrees * (float) currentTime.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0,0, minuteToDegrees * (float) currentTime.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0,0,secondToDegrees * (float) currentTime.TotalSeconds);
    }
}
