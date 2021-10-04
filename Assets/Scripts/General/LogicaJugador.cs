using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaJugador : MonoBehaviour
{
    public Vida vida;
    public bool Vida0 = false;
    [SerializeField] private Animator animadorPerder;
    public Puntos puntos;

    // Start is called before the first frame update
    void Start()
    {
        vida = GetComponent<Vida>();
        puntos.valor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
    }

    void RevisarVida()
    {
        if (Vida0) return;
        if(vida.valor <= 0)
        {
            AudioListener.volume = 0f;
            animadorPerder.SetTrigger("Mostrar");
            Vida0 = true;
            Invoke("ReiniciarJuego", 4f);
        }
    }

    void ReiniciarJuego()
    {
        SceneManager.LoadScene("Menu");
        puntos.valor = 0;
        AudioListener.volume = 1f;
    }
}
