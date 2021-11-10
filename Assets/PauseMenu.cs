using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject Player;
    public GameObject Camera;
    private characterScript refScript;
    private cameraForPickingShitup cameraScript;

    void Start()
    {
        refScript = Player.GetComponent<characterScript>();
        cameraScript = Camera.GetComponent<cameraForPickingShitup>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (isGamePaused)
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
        refScript.enabled = true;
        cameraScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void Pause()
    {
        refScript.enabled = false;
        cameraScript.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void BackToStart()
    {
        refScript.enabled = true;
        cameraScript.enabled = true;
        SceneManager.LoadScene("SkyBoxStartScreen");
    }

    public void LoadMenu()
    {

    }
}
