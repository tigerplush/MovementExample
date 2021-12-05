using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MessageCharacterController : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentDiff = new Vector3(movement.x, 0f, movement.y);
        transform.position += currentDiff * Time.deltaTime * movementSpeed;
    }

    public void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
}
