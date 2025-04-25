using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio9 : MonoBehaviour
{
    public int a = 15;
    public int b = 16;

 private void MinoreTra2()
    {
        if (a < b)
            Debug.Log("Minore");
    }
    void Start()
    {
        MinoreTra2();
    }

    
    
}
