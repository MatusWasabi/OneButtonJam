
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private InputAction action;
    private Vector2 direction;



    private void Awake()
    {
        InputActionMap pedastrainMap =  playerInput.actions.FindActionMap("Pedastrain");
        action = pedastrainMap.FindAction("Move");
    }

    private void OnEnable()
    {
        action.performed += OnMoveStart;
        action.canceled += OnMoveStop;
        action.Enable();    
    }

    private void OnDisable()
    {
        action.performed -= OnMoveStart;
        action.canceled -= OnMoveStop;
        action.Disable();
    }

    private void OnMoveStart(CallbackContext context)
    {
        Debug.Log("Start");
        direction = context.ReadValue<Vector2>();
        MoveObject();
    }


    private void OnMoveStop(CallbackContext context)
    {
        Debug.Log("Stop");
        direction = Vector2.zero;
        MoveObject();
    }


    private void MoveObject()
    {
        rb.velocity = direction * speed;
        Debug.Log("Move is called");
    }
    
}
