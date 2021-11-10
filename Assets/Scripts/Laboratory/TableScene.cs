using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TableScene : MonoBehaviour
{

    void OnMouseDown()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        //when table is clicked on scene changes to labtable1
        SceneManager.LoadScene("LabTable1");
    }
   /*
    // Update is called once per frame
    void Update()
    {
        //when table is clicked on scene changes to labtable1
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject)
            SceneManager.LoadScene("LabTable1");
        }
    }
   */
}
