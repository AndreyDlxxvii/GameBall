using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float Gravity;
    private int _val;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = Gravity;
        
    }
    void Update()
    {
        print(_val);
        if (Input.GetKeyDown("space"))
        {
            _rb.gravityScale = _rb.gravityScale * -1;
        }
    }
    public void SlidEvent(Slider sl)
    {
        _val = (int)sl.value;
    }
}
