using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherFuck : MonoBehaviour, orbsYo
{
    public void OnStartLook()
    {
        Debug.Log("Started looking at");
    }

    public void OnInteract()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Laboratory");
    }

    public void OnEndLook()
    {
        Debug.Log("Stopped Looking at");
    }

}
