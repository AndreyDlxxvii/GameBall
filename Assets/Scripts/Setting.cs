using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    private int _val;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void SlidEvent (Slider sl)
    {
        _val = (int)sl.value;
    }
    private void Update()
    {
        Debug.Log(_val);
    }
}
