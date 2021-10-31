using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }
}
