using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    public int a = 13;
    public int b = 12;
    private void MaggioreTra2()
    {
        if (a > b)
            Debug.Log("Maggiore");

    }

    private void Start()
    {
        MaggioreTra2 ();
    }




}