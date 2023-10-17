using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{
    public float Timer
    {
        get { return timer; }
    }

    private float timer;

    public static GameManager Instance;

    public event System.Action<float> OnTimerChanged;

    private float totalGameTime;

    public float TotalGameTime
    {
        get { return totalGameTime; }
    }

    private int currentLevelIndex;
    private bool isTimerOn;
    private float currentTimer;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
            Instance = this;
        else
        { 
            Destroy(gameObject);

            //RestartGame();
        }
    }

    private void Update()
    {
        //CountTime();
        timer += Time.deltaTime;

        totalGameTime += Time.deltaTime;

        OnTimerChanged?.Invoke(timer);
    }

    public void MoveToNextLevel()
    {
        currentLevelIndex++;
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void RestartGame()
    {
        timer = 0;

        SceneManager.LoadScene(currentLevelIndex);
    }
}
