using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{
    private GameObject go;

    private List<Vector3> pos;

    private Transform myTransform;
    private float speed = 5.0f;

    private void Start()
    {
        go = GameObject.Find("UserControlledChar");
    }

    void Update()
    {
        myTransform = go.GetComponent<Transform>();

        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
}
