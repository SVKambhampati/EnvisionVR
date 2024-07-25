using System;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public OVRInput.Controller controller = OVRInput.Controller.LTouch;

    private void Update()
    {
        // Get thumbstick input
        Vector2 thumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller);

        // Calculate movement direction based on camera's forward
        Vector3 moveDirection = transform.forward * thumbstick.y + transform.right * thumbstick.x;

        // Apply movement to camera
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
