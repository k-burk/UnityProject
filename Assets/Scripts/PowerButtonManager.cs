using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerButtonManager : MonoBehaviour {
    public Button PowerButton;

    // Start is called before the first frame update
    void Start() {
        PowerButton.onClick.AddListener(TaskOnClick_PowerButton);
    }

    // Update is called once per frame
    void Update() {

    }

    void TaskOnClick_PowerButton() {
        // Display TV remote to user when clicking button by loading TV Remote scene
        SceneManager.LoadScene("TV");
    }
}