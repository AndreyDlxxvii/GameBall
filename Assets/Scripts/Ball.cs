using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float _jump;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        Jump();
    }


    void Update()
    {
        _jump = Input.GetAxis("Jump");
        print(_jump);
    }
    private void Jump()
    {
        _rb.gravityScale = _rb.gravityScale * _jump;
    }
}
