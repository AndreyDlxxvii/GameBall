using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float Gravity;
    public GameObject Setting;

    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneManager.LoadScene(2);
    }


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = Gravity;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _rb.gravityScale = _rb.gravityScale * -1;
        }
    }
}
