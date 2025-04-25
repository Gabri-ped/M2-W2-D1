using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Esercizio10 : MonoBehaviour
{
    float time = 0;


    // Update is called once per frame
    void Update()
    {
        
      
        time += Time.deltaTime;
        Debug.Log(time);
        if (time > 60f)
        {
                Debug.Log("sono trascorsi 60 secondi");   
        }
        else if (time >= 45f)
            {
            Debug.Log("Sono trascorsi 45 secondi");
        }
        

    }
}
