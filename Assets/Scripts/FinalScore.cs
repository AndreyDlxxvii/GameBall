using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    void Start()
    {
        //вывод очков на экран Game Over
        var temp = GameObject.FindWithTag("Score").GetComponent<Score>().GameScore;
        GetComponent<Text>().text = temp.ToString();
    }
}