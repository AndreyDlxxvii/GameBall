using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BorderManagement : MonoBehaviour
{
    private BoxCollider2D _collBox;
    private RectTransform _rectTrans;
    
    void Start()
    {
        _rectTrans = GetComponent<RectTransform>();
        _collBox = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        _collBox.offset = new Vector2(-_rectTrans.sizeDelta.x/2,0);
        _collBox.size = new Vector2(1, _rectTrans.sizeDelta.y);
    }
}
