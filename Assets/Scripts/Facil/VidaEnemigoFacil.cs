using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoFacil : MonoBehaviour
{
    public float valor = 100;
    public VidaEnemigoFacil padreRef;
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
        valor -= 8;
        if (valor < 0)
        {
            valor = 0;
        }
    }
}
