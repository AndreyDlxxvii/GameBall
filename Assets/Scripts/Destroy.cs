﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("пуф");
        Destroy(gameObject);
    }
}
