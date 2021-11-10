using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComAudio : MonoBehaviour
{
    public AudioClip rocktalk;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().clip = rocktalk;
            GetComponent<AudioSource>().Play();
        }

    }
}
