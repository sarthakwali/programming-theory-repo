using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // -ENCAPSULATION
    private float v_moveSpeed = 5f;
    public float moveSpeed
    {
        get
        {
            return v_moveSpeed;
        }

        protected set
        {
            if (value < 0.0f)
                Debug.LogError("Trying to set moveSpeed to a value less than 0");
            else
                v_moveSpeed = value;
        }
    }
    private float v_rotateSpeed = 50f;
    public float rotateSpeed
    {
        get
        {
            return v_rotateSpeed;
        }

        protected set
        {
            if (value < 0.0f)
                Debug.LogError("Trying to set moveSpeed to a value less than 0");
            else
                v_rotateSpeed = value;
        }
    }

    public Vector3 cameraOffset { get; protected set; }
    // -
    public GameObject mainCamera;

    // -POLYMORPHISM
    protected virtual void Move()
    { 
    
    }

    protected virtual void CameraFollow()
    { 
    
    }
    // -
}
