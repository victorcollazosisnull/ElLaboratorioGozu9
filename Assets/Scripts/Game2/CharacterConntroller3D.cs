using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CharacterConntroller3D : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 5f;
    public float jump = 5f;

    private Rigidbody _rigidbody;
    private Vector3 movementInput;
    private bool isGrounded;  

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementInput.x, 0, movementInput.z) * speed;
        movement.y = _rigidbody.velocity.y; 

        _rigidbody.velocity = movement;
    }

    public void ReadDirection(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        movementInput = new Vector3(input.x, 0, input.y); 
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)  
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * jump, ForceMode.Impulse);
        isGrounded = false;  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            isGrounded = true;  
        }
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
