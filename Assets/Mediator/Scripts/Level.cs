using System;
using UnityEngine;

public class Level
{
    public event Action Defeat;

    public void Start()
    {
        //логика старта
        Debug.Log("StartLevel");
    }

    public void Restart()
    {
        //логика очистка уровня
        Start();
    }

    public void OnDefeat()
    {
        //логика остановки игры
        Defeat?.Invoke();
    }
}
