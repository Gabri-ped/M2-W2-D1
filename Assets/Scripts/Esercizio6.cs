
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    public int Partenza = 19;
    private void Stampa2Successivi()
    {

        Debug.Log(Partenza + " " + Partenza++ + " " + Partenza++);
    }

    private void Start()
    {
        Stampa2Successivi();
    }

}