using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void LoadLevel()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("whackACube");



    }

    public void Quit()
    {

        Application.Quit();



    }
}
