using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToHubButtonManager : MonoBehaviour {
    public Button BackToHubButton;

    // Start is called before the first frame update
    void Start() {
        BackToHubButton.onClick.AddListener(TaskOnClick_BackToHubButton);
    }

    // Update is called once per frame
    void Update() {

    }

    void TaskOnClick_BackToHubButton() {
        // Display TV remote to user when clicking button by loading TV Remote scene
        SceneManager.LoadScene("OutsideStartingPoint");
    }
}