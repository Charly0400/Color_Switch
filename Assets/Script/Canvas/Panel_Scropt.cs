using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel_Scropt : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void ClosePanel()
    {
        GetComponent<Animator>().SetTrigger("Close");
    }

    public void SetTimePlay()
    {
        Time.timeScale = 1;
    }
    public void CreditScene()
    {

        GetComponent<Animator>().SetTrigger("CreditScene");
    }
    public void ExitCreditScene()
    {
        GetComponent<Animator>().SetTrigger("ExitCreditScene");
    }

    public void ControllersEscene()
    {
        GetComponent<Animator>().SetTrigger("ControllersEscene");
    }
    public void ExitControllersEscene()
    {
        GetComponent<Animator>().SetTrigger("ExitControllersEscene");
    }
    public void GameOverescene()
    {
        GetComponent<Animator>().SetTrigger("OpenGameOver");
    }
    public void Salir()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Salir");
    }
    public void Restart()
    {
        //Funci�n que resete� todo a su lugar
        SceneManager.LoadScene(0);
    }

}
