using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerHolder : MonoBehaviour
{
    public static TimerHolder Instance;

    private float totalGameTime;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void UpdateTotalGameTime(float deltaTime)
    {
        totalGameTime += deltaTime;
    }

    public float GetTotalGameTime()
    {
        return totalGameTime;
    }
}
