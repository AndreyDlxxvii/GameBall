using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //уничтожение блоков при покидании сцены
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
