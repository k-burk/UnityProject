using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButtonManager : MonoBehaviour {
    public Button BackButton;

    // Start is called before the first frame update
    void Start() {
        BackButton.onClick.AddListener(TaskOnClick_BackButton);
    }

    // Update is called once per frame
    void Update() {

    }

    void TaskOnClick_BackButton() {
        // Display TV remote to user when clicking button by loading TV Remote scene
        SceneManager.LoadScene("MartianHome");
    }
}