using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpMechanic : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Rigidbody2D body;
    private InputAction jumpAction;
    private Player control;

    private void Awake()
    {
        control = new Player();
        InputActionMap map = playerInput.currentActionMap;
        //jumpAction = map.FindAction("Jump");
        control.Enable();
        jumpAction = control.Pedastrain.Jump;
    }

    private void OnEnable()
    {
        
        jumpAction.started += OnJumpStart;
    }

    private void OnDisable()
    {
        jumpAction.started -= OnJumpStart;
    }

    private void OnJumpStart(InputAction.CallbackContext context)
    {
        body.AddRelativeForce(Vector2.up * body.gravityScale * 200);
    }
}
