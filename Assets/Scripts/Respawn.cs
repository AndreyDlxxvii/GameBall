using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] Shell;
    public float Power;
    //позиции респа блоков на экране
    public Camera ThisCam;
    public RectTransform ThisCanvas;
    private Vector2 _pos1, _pos2;
    void Start()
    {
        //вызываем функцию респавна блоков каждые 5 сек
        InvokeRepeating("Spawn", 0, 5);
    }

    private void Spawn ()
    {
        //получаем глобальные координаты из локальных координат канваса для дальнейшего получения
        //точек респавна с глобалными координатами
        Vector2 tempPosition = ThisCam.ScreenToWorldPoint(ThisCanvas.position);

        //создаем по два рандомных объекта из массива префбов и приклыдваем силу для движения 
        GameObject temp = Instantiate(Shell[Random.Range(0, Shell.Length)], new Vector2(-tempPosition.x, tempPosition.y + 1), Quaternion.identity) as GameObject;
        //var _rb = temp.GetComponent<Rigidbody2D>();
        //_rb.AddForce(Vector2.left * Power);


        GameObject temp1 = Instantiate(Shell[Random.Range(0, Shell.Length)], new Vector2(-tempPosition.x, -tempPosition.y - 1), Quaternion.identity) as GameObject;
        //var _rb1 = temp1.GetComponent<Rigidbody2D>();
        //_rb1.AddForce(Vector2.left * Power);
    }
}
