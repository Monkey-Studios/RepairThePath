using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("The Game has shutdown");
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }


}
