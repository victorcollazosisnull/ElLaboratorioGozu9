using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody2D;
    private Vector2 movementInput;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void ReadDirection(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = movementInput * speed;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
