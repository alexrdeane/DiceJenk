using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Camera attachedCamera;
    public float xSpeed = 120f, ySpeed = 120f;
    public float minYAngle = 30f, maxYAngle = 80f;

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 euler = transform.eulerAngles;

        euler.x -= mouseY * ySpeed * Time.deltaTime;
        euler.y += mouseX * ySpeed * Time.deltaTime;

        transform.eulerAngles = euler;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Rotate();
        }
    }
}
