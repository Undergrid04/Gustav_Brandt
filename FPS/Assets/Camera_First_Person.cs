using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_First_Person : MonoBehaviour
{

    public float mouseSensivity = 100f;

    public Transform Cylinder;

    float xRotation = 0f;

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Cylinder.Rotate(Vector3.up * mouseX);



    }
}