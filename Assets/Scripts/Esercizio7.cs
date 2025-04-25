using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int Partenza = 18;
    private void Stampa2Precedenti()
    {

        Debug.Log(Partenza +  " " + Partenza-- + " " + Partenza--);
    }

    private void Start()
    {
        Stampa2Precedenti();
    }

}