using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


/// <summary>
/// Responsible for acknowleding decision from player
/// In this context, it can be only yes or no. 
/// </summary>
public class DecisionMaker : MonoBehaviour
{
    private Player playerController;
    private InputAction confirmAction;
    [SerializeField] private UnityEvent<bool> onDecisionMade;

    private void Awake()
    {
        //inputActions.Enable();
        if (playerController is null)
        {
            playerController = new Player();
        }
        playerController.Enable();
        confirmAction = playerController.Choice.Confirm;
    }

    private void OnEnable()
    {
        confirmAction.performed += Confirm;
        confirmAction.canceled += Reject;
    }

    private void OnDisable()
    {
        confirmAction.performed -= Confirm;
        confirmAction.canceled -= Reject;
    }

    public void EnableInput()
    {
        if (playerController is null)
        {
            playerController = new Player();
        }
        playerController.Enable();
    }

    public void DisableInput()
    {
        if (playerController is null)
        {
            playerController = new Player();
        }
        playerController.Enable();
        playerController.Disable();
    }

    private void Confirm(InputAction.CallbackContext context)
    {
        onDecisionMade.Invoke(true);
    }

    private void Reject(InputAction.CallbackContext obj)
    {
        onDecisionMade.Invoke(false);
    }
}
