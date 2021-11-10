
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    private GameObject go;
    //public Animation anim;
    //private List<Vector3> pos;

    private Transform myTransform;
    private float speed = 5.0f;

    private void Start()
    {
        go = GameObject.Find("UserControllerChar");
    }

    void Update()
    {
        myTransform = go.GetComponent<Transform>();
       // anim = go.GetComponent<Animator>();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //anim.Play(anim);
            myTransform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //anim.Play(anim);
            myTransform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
    }
}
