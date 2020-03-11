using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] Shell;
    public float Power;
    //позиции респа блоков на экране
    public RectTransform Pos1, Pos2;
    private Vector2 _pos1, _pos2;
    void Start()
    {
        //вызываем функцию респавна блоков каждые 5 сек
        InvokeRepeating("Spawn", 0, 5);
    }

    private void Spawn ()
    {
        //создаем по два рандомных объекта из массива префбов и две точки респавна с привязкой к размеру окна и приклыдваем силу для движения 
        _pos1 = new Vector2(Pos1.position.x, Pos1.position.y);
        GameObject temp = Instantiate(Shell[Random.Range(0, Shell.Length)], _pos1, Quaternion.identity) as GameObject;
        var _rb = temp.GetComponent<Rigidbody2D>();
        _rb.AddForce(Vector2.left * Power);



        _pos2 = new Vector2(Pos2.position.x, Pos2.position.y);
        GameObject temp1 = Instantiate(Shell[Random.Range(0, Shell.Length)], _pos2, Quaternion.identity) as GameObject;
        var _rb1 = temp1.GetComponent<Rigidbody2D>();
        _rb1.AddForce(Vector2.left * Power);
    }
}
