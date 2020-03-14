using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    private int _val;
public void SlidEvent (Slider sl)
    {
        _val = (int)sl.value;
    }
}
