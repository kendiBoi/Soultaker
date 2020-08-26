using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        SoundManager.PlaySound("ButtonSound");
        SceneManager.LoadScene("startScene");
    }

    public void QuitGame()
    {
        SoundManager.PlaySound("ButtonSound");
        Application.Quit();
    }
}
