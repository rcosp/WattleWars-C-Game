using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miprimerscript : MonoBehaviour
{
    public Texture Icono;
    public int CoordenadaX = 0;
    public int CoordenadaY = 0;
    public int Ancho = 100;
    public int Alto = 50;

    // Start is called before the first frame update
    void Start() => Debug.Log("Hola al principio");


    // Update is called once per frame
    void Update() => Debug.Log("Hola en bucle");


    void Awake() => Debug.Log("Hola aunque este desactivado");


    void OnGUI()
    {
        GUI.Label(new Rect(500, 500, 100, 50), "Hola mundo");
        GUI.Label(new Rect(CoordenadaX, CoordenadaY, Ancho, Alto), Icono);
    }
}
