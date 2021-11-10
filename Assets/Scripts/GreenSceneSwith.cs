using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenSceneSwith : MonoBehaviour, orbsYo
{
    public void OnStartLook()
    {
        Debug.Log("Started looking at");
    }

    public void OnInteract()
    {
        SceneManager.LoadScene("MartianHome");
    }

    public void OnEndLook()
    {
        Debug.Log("Stopped Looking at");
    }
}
