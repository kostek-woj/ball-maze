using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_Tilting : MonoBehaviour
{
    private Vector3 _currentRotation;
    
    private void Update()
    {
        _currentRotation = GetComponent<Transform>().eulerAngles;

        // Tilt left
        if (Input.GetKey(KeyCode.A) && (_currentRotation.x <= 10f || _currentRotation.x >= 350f))
        {
            transform.Rotate(-.5f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        
        
        // Tilt right
        if (Input.GetKey(KeyCode.D)  && (_currentRotation.x >= 351f || _currentRotation.x <= 9f))
        {
            transform.Rotate(.5f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        
        // Tilt back
        if (Input.GetKey(KeyCode.W) && (_currentRotation.z <= 10f || _currentRotation.z >= 350f))
        {
            transform.Rotate(0, 0, .5f);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        
        // Tilt forward
        if (Input.GetKey(KeyCode.S) && (_currentRotation.z >= 351f || _currentRotation.z <= 9f))
        {
            transform.Rotate(0, 0, -.5f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
    }
}
