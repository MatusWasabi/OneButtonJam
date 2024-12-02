using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// This is strong-typed reference using player input and generated class.
/// This wat we can do fine-grained control without touching unity events of player inputs.
/// Why don't just use unity events of playerinput class? Ans: It somewhat risks version controlling breaking.
/// </summary>
public class StrongTypeController : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Player player;
    private InputAction confirmAction;


    private void Awake()
    {
        player = new Player();
        //playerInput.actions = player.asset;
    }

    private void OnEnable()
    {
        confirmAction = playerInput.actions.FindAction(player.Choice.Confirm.id);
        confirmAction.performed += Confirm_performed;
        //player.Enable();
        //player.Choice.Confirm.performed += Confirm_performed;
    }



    private void OnDisable()
    {
        //player.Disable();
        //player.Choice.Confirm.performed -= Confirm_performed;
    }


    private void Confirm_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Call by generated class!");
    }


}
