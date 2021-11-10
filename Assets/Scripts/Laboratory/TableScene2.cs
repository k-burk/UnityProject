using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TableScene2 : MonoBehaviour
{
    void OnMouseDown()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
      
        //when table is clicked on scene changes to labtable2
        SceneManager.LoadScene("LabTable2");
    }

    /*
    // Update is called once per frame
    void Update()
    {
        //when table is clicked on scene changes to labtable2
        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene("LabTable2");
        }
    }
    */
}
