using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour {

    public static bool juegoEnPausa = false;
    public GameObject menuUI;
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(juegoEnPausa)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        juegoEnPausa = false;
    }

    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        juegoEnPausa = true;
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        juegoEnPausa = false;
        if (Puntaje.puntos >= Puntaje.mejorPuntaje)
        {
            Puntaje.mejorPuntaje = Puntaje.puntos;
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit game ...");
        Application.Quit();
    }
}
