using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color Blue;

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.CompareTag("Sphere 1"))
            {
                col.transform.GetComponent<Renderer>().material.color = Blue;
            }

        }

    }
    
}
