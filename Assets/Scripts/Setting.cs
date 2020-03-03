using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    private int val;
public void SlidEvent (Slider sl)
    {
        val = (int)sl.value;
    }
}
