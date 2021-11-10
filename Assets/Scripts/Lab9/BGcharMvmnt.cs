using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGcharMvmnt : MonoBehaviour
{
    public float speed = 1.0f;
    public float x = 0.0f;
    public float z = 0.0f;
    public GameObject character;
    public Vector3 characterPos;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // initialize char
        //character = GameObject.Find("Char2");

        //characterPos = GameObject.Find("Char2").transform.position;
        /*
        if(characterPos.x > 0 && characterPos.x < 50 && characterPos.z > 0 && characterPos.z < 50) {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, speed*Time.deltaTime));
        }

        else {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, -speed * Time.deltaTime));
            if(characterPos.x > 50 || characterPos.z > 50) {
                if(characterPos.x > 50) {
                    //transform.Translate(new Vector3(-50, 0 ,0));
                    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, speed * Time.deltaTime));
                }
                if(characterPos.z > 50) {
                    //transform.Translate(new Vector3(0, 0, -50));
                    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, speed * Time.deltaTime));
                }
        }*/
        velocity = gameObject.transform.position;
        x = velocity[0];
        z = velocity[0];

        if (x >=0 && x <=50 && z >=0 && z <=50)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, speed * Time.deltaTime));
        }
        else
        {
            gameObject.transform.Translate(new Vector3(0, 0, 0));
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, -speed * Time.deltaTime));
            transform.Translate(new Vector3(0, 0, 0));

            Debug.Log("Going back");
        }
        if (x < 0 && x >= 50 && z <= 0 && z >= 50)
        {
            transform.Translate(new Vector3(0, 0, 0));
            Debug.Log("Going back");
        }
    }
}