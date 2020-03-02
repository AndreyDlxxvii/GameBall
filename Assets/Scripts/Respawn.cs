using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] Shell;
    public float Power;

    private Vector2 _pos1 =new Vector2(10f,4.3f), _pos2= new Vector2(10f, -4.3f);
    



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 5);

    }

    private void Spawn ()
    {
        GameObject temp = Instantiate(Shell[Random.Range(0, Shell.Length)], _pos1, Quaternion.identity) as GameObject;
        var _rb = temp.GetComponent<Rigidbody2D>();
        _rb.AddForce(Vector2.left * Power);
        GameObject temp1 = Instantiate(Shell[Random.Range(0, Shell.Length)], _pos2, Quaternion.identity) as GameObject;
        var _rb1 = temp1.GetComponent<Rigidbody2D>();
        _rb1.AddForce(Vector2.left * Power);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
