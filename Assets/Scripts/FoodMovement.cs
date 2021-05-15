using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float speed = 30f;
    public float rotationSpeed = 500f;
    
    void Update()
    {
        float speedScale = Time.deltaTime * speed;
        transform.Translate(Vector3.forward * speedScale, Space.World);
        
        
        float rotationSpeedScale = Time.deltaTime * rotationSpeed;
        transform.Rotate(Vector3.up, rotationSpeedScale);
    }
}
