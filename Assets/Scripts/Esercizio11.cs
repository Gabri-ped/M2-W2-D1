using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Esercizio11 : MonoBehaviour
{
    public float voto = 9;
    // Start is called before the first frame update
    void Start()
    {
        if (voto >= 10)
            Debug.Log("A+");
        else if (voto >= 9)
            Debug.Log("A");
        else if (voto >= 7.8f)
            Debug.Log("B");
        else if (voto >= 6)
            Debug.Log("C");
        else if (voto >=5f)
            Debug.Log("E");
        else if (voto >= 0.4f)
            Debug.Log("F");
        

        
      



}
    // Update is called once per frame
    void Update()
    {
        
    }
}
