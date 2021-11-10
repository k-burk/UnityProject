using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeButtonManager : MonoBehaviour {
    public Button TimeButton;

    // Start is called before the first frame update
    void Start() {
        TimeButton.onClick.AddListener(TaskOnClick_TimeButton);
    }

    // Update is called once per frame
    void Update() {

    }

    void TaskOnClick_TimeButton() {
        // Display TV remote to user when clicking button by loading TV Remote scene
        SceneManager.LoadScene("TimeOnMars");
    }
}