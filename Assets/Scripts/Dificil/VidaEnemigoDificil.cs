using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoDificil : MonoBehaviour
{
    public float valor = 100;
    public VidaEnemigoDificil padreRef;
    public float multiplicadorDeDaño = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RecibirDaño(float daño)
    {
        daño *= multiplicadorDeDaño;
        if (padreRef != null)
        {
            padreRef.RecibirDaño(daño);
            return;
        }
        valor -= 2;
        if (valor < 0)
        {
            valor = 0;
        }
    }
}
