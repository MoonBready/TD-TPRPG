using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float Timer { get; private set; }

    public static GameManager Instance { get; private set; }

    public event Action<float> OnTimerChanged;

    private int currentLevelIndex;
    private bool isTimerOn;
    private float currentTimer;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Timer = 0;
            Instance = this;
            DontDestroyOnLoad(gameObject);

            RestartGame();
        }
    }

    private void Update()
    {
        CountTime();
    }

    public void CountTime()
    {
        if (currentLevelIndex < 1 || currentLevelIndex >= 4)
        {
            isTimerOn = false;
            currentTimer = Timer;
        }
        else
        {
            isTimerOn = true;
            if (isTimerOn)
                Timer += Time.deltaTime;

            OnTimerChanged?.Invoke(Timer);
        }
    }

    public void MoveToNextLevel()
    {
        currentLevelIndex++;
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void RestartGame()
    {
        Timer = 0;

        SceneManager.LoadScene(currentLevelIndex);
    }
}
