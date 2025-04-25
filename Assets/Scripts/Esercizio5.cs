using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{ public int a = 14;
    private string stringadidebug;
    // Start is called before the first frame update
    void Start()
    {
        if (a % 2 == 0)
        {
           stringadidebug = "Pari";
        }
        else
        {
            stringadidebug = "Dispari";
        }
        if (a > 10)
        {
            stringadidebug = stringadidebug + " Maggiore di 10";
        }
 Debug.Log(stringadidebug);
        
    }
    
       
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
