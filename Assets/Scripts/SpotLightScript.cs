using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightScript : MonoBehaviour
{
    private Light spotlight;
    // Start is called before the first frame update
    void Start()
    {
        spotlight = GetComponent<Light>();
        spotlight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (spotlight.enabled)
        {
            spotlight.enabled = true;
        }
    }
}
