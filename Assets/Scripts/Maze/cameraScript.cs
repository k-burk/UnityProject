using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    float Yrot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public Transform playerBody;
    public float sensitivity = 100f;

    void Update()
    {
        Yrot -= Input.GetAxis("Mouse Y") * sensitivity;
        Yrot = Mathf.Clamp(Yrot, -60, 80);
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(Yrot, 0, 0); 
        


    }
}
