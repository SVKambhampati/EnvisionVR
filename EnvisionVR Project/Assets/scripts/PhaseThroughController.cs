using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseThroughController : MonoBehaviour
{
    public CharacterController characterController;

    private void Start()
    {
        //characterController = GetComponent<CharacterController>();
        characterController.detectCollisions = false;
    }

    private void Update()
    {
        // Implement your custom movement logic here
        // For example:
        //transform.Translate(Vector3.forward * Time.deltaTime);
    }
}

