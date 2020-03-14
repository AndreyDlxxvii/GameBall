using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    private float _speed = 0.05f;
    private Vector2 _vector2;

    private void Start()
    {
        _vector2 = new Vector2(-1, 0);
    }
    void FixedUpdate()
    {
        transform.Translate(_vector2.normalized*_speed);
    }
}
