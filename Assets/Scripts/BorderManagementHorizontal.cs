using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderManagementHorizontal : MonoBehaviour
{
    private BoxCollider2D _collBox;
    public Canvas Can;
    void Start()
    {
        _collBox = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        _collBox.offset = new Vector2(0, 0);
        _collBox.size = new Vector2(Can.pixelRect.width, Can.pixelRect.height/1.67f);
    }
}
