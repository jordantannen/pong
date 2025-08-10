using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputAction MoveAction;
    public float speed = 6f;
    public float maxY = 4f;
    public float minY = -4f;
    
    private void Start()
    {
        MoveAction.Enable();
    }

    private void Update()
    {
        float movementDirection = MoveAction.ReadValue<float>();
        Vector3 pos = transform.position;
        
        pos.y += movementDirection * speed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        
        transform.position = pos;
    }
}
