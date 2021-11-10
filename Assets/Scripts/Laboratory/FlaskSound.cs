using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskSound : MonoBehaviour
{
    public AudioClip bubble;
    
  
    void OnMouseDown()
    {
        GetComponent<AudioSource>().clip = bubble;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().clip = bubble;
            GetComponent<AudioSource>().Play();
        }
    }
}
