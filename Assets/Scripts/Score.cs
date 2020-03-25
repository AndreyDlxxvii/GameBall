using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int GameScore;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        GameScore = 5;
    }

    void Update()
    {
        
    }
}
