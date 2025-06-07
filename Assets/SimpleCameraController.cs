using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    public Transform target; // El jugador o un empty en �l
    public float rotationSpeed = 5f;
    public float verticalMin = -30f;
    public float verticalMax = 60f;

    private float yaw;   // rotaci�n horizontal
    private float pitch; // rotaci�n vertical

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, verticalMin, verticalMax);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
    }
}