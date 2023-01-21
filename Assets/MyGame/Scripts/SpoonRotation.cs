using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonRotation : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 30f;
    public float maxRotationAngle = 45f;
    private float currentRotation = 0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(horizontal, vertical) * moveSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (currentRotation < maxRotationAngle)
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
                currentRotation += rotationSpeed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (currentRotation > -maxRotationAngle)
            {
                transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
                currentRotation -= rotationSpeed * Time.deltaTime;
            }
        }
    }
}
