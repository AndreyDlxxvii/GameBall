﻿using UnityEngine;
using UnityEngine.SceneManagement;      

public class StartGame : MonoBehaviour
{
    public void GameStart(int i)
    {
        SceneManager.LoadScene(i);
        if (i == 0)
        {
            Destroy(GameObject.FindWithTag("Score"));
        }
    }
    
}
