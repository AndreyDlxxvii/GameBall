using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BorderManagement : MonoBehaviour
{
    private BoxCollider2D collBox;
    private RectTransform rectTrans;
    
    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        collBox = GetComponent<BoxCollider2D>();
        print(rectTrans.sizeDelta);
    }

    // Update is called once per frame
    void Update()
    {
        collBox.offset = new Vector2(-rectTrans.sizeDelta.x/2,0);
        collBox.size = new Vector2(1, rectTrans.sizeDelta.y);
    }
}
