/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

// basic WASD-style movement control
public class MovePlayer : MonoBehaviour {
    [SerializeField] private Camera headCam;

    public float speed = 6.0f;
    public float gravity = 0f;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float rotationVert = 0;

    private CharacterController charController;

    void Start() {
        charController = GetComponent<CharacterController>();
    }

    void Update() {
        MoveCharacter();
        RotateCamera();
    }

    private void MoveCharacter() {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);

        charController.Move(movement);
    }

    private void RotateCamera() {
        headCam.transform.localEulerAngles = new Vector3(
            rotationVert, headCam.transform.localEulerAngles.y, 0
        );
    }
}
*/