using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLab : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Laboratory");
    }
}