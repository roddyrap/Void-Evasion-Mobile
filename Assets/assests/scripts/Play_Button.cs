﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadSceneAsync("Game", mode: LoadSceneMode.Single);
    }
}