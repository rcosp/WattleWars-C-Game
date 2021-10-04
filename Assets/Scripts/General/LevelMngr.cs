using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class LevelMngr : MonoBehaviour
{
    public void EscenaFacil()
    {
        SceneManager.LoadScene("Escena 1");
        Debug.Log("Entrar al nivel facil");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EscenaNormal()
    {
        SceneManager.LoadScene("Escena 2");
        Debug.Log("Entrar al nivel normal");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EscenaAlbareda()
    {
        SceneManager.LoadScene("Escena 3");
        Debug.Log("Entrar al nivel dificil");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SaliR()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
}
