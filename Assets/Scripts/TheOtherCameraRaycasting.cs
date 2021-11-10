using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheOtherCameraRaycasting : MonoBehaviour
{
    [SerializeField] private float raycastDistance;

    private orbsYo currentTarget;

    private void Update()
    {
        HandleRaycast();

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTarget != null)
            {
                currentTarget.OnInteract();
            }
        }
    }

    private void HandleRaycast()
    {
        RaycastHit whatIHit;

        if (Physics.Raycast(transform.position, transform.forward, out whatIHit, raycastDistance))
        {
            orbsYo orbs = whatIHit.collider.GetComponent<orbsYo>();

            if (orbs != null)
            {
                if (orbs == currentTarget)
                {
                    return;
                }
                else if (currentTarget != null)
                {
                    currentTarget.OnEndLook();
                    currentTarget = orbs;
                    currentTarget.OnStartLook();
                }
                else
                {
                    currentTarget = orbs;
                    currentTarget.OnStartLook();

                }
            }
            else
            {
                if (currentTarget != null)
                {
                    currentTarget.OnEndLook();
                    currentTarget = null;
                }
            }
        }
        else
        {
            if (currentTarget != null)
            {
                currentTarget.OnEndLook();
                currentTarget = null;
            }
        }
    }


}
