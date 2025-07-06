using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// - INHERITANCE
public class Car : Vehicle
{
    private void Start()
    {
        moveSpeed = 10f;
        rotateSpeed = 150f;
        cameraOffset = mainCamera.transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void LateUpdate()
    {
        CameraFollow();
    }

    // --POLYMORPHISM
    // ---ABSTRACTION
    protected override void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    protected override void CameraFollow()
    {
        mainCamera.transform.position = transform.position + cameraOffset;
    }
    // ---
    // --
}
// -
