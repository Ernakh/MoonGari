using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void CarregarFase()
    {
        SceneManager.LoadScene("Game");
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}
