//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Player.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Pedastrain"",
            ""id"": ""76e7da05-848d-4679-8531-8df7d8b13925"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6ee6daa1-5eba-4a6b-9d67-6a58f8181e87"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2e4779b6-5b6a-4887-b690-0dd79806ee29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""245434ca-6b4c-425f-9dc4-a9b11492e755"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bc76d3a9-69ff-42ce-8ff7-85ed6abdd7af"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e6637e0b-9a17-4d47-8e65-ba0873132a75"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8539aac8-90d4-4623-ab02-43574751d9e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6e417723-79b1-47e9-ac44-e493ebe64144"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""277f1246-b63d-4f29-a7fb-0a5c79065c37"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09963689-c22e-49f3-8f90-292de6627164"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""959abd20-d489-4615-ad5b-e549b5556d75"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Choice"",
            ""id"": ""4b4c8750-3920-4a3e-b715-e7254c870f1e"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""f38af66c-e0c8-4c2d-8907-1fc25e4d12bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1ad938ca-7ab7-41a9-8bfd-8177a481ca40"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9a3aa7f-a2a5-4fa8-bcf8-8165a797e225"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""JoyStick"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""JoyStick"",
            ""bindingGroup"": ""JoyStick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Pedastrain
        m_Pedastrain = asset.FindActionMap("Pedastrain", throwIfNotFound: true);
        m_Pedastrain_Move = m_Pedastrain.FindAction("Move", throwIfNotFound: true);
        m_Pedastrain_Jump = m_Pedastrain.FindAction("Jump", throwIfNotFound: true);
        // Choice
        m_Choice = asset.FindActionMap("Choice", throwIfNotFound: true);
        m_Choice_Confirm = m_Choice.FindAction("Confirm", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Pedastrain
    private readonly InputActionMap m_Pedastrain;
    private List<IPedastrainActions> m_PedastrainActionsCallbackInterfaces = new List<IPedastrainActions>();
    private readonly InputAction m_Pedastrain_Move;
    private readonly InputAction m_Pedastrain_Jump;
    public struct PedastrainActions
    {
        private @Player m_Wrapper;
        public PedastrainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Pedastrain_Move;
        public InputAction @Jump => m_Wrapper.m_Pedastrain_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Pedastrain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PedastrainActions set) { return set.Get(); }
        public void AddCallbacks(IPedastrainActions instance)
        {
            if (instance == null || m_Wrapper.m_PedastrainActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PedastrainActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPedastrainActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPedastrainActions instance)
        {
            if (m_Wrapper.m_PedastrainActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPedastrainActions instance)
        {
            foreach (var item in m_Wrapper.m_PedastrainActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PedastrainActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PedastrainActions @Pedastrain => new PedastrainActions(this);

    // Choice
    private readonly InputActionMap m_Choice;
    private List<IChoiceActions> m_ChoiceActionsCallbackInterfaces = new List<IChoiceActions>();
    private readonly InputAction m_Choice_Confirm;
    public struct ChoiceActions
    {
        private @Player m_Wrapper;
        public ChoiceActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_Choice_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_Choice; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChoiceActions set) { return set.Get(); }
        public void AddCallbacks(IChoiceActions instance)
        {
            if (instance == null || m_Wrapper.m_ChoiceActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ChoiceActionsCallbackInterfaces.Add(instance);
            @Confirm.started += instance.OnConfirm;
            @Confirm.performed += instance.OnConfirm;
            @Confirm.canceled += instance.OnConfirm;
        }

        private void UnregisterCallbacks(IChoiceActions instance)
        {
            @Confirm.started -= instance.OnConfirm;
            @Confirm.performed -= instance.OnConfirm;
            @Confirm.canceled -= instance.OnConfirm;
        }

        public void RemoveCallbacks(IChoiceActions instance)
        {
            if (m_Wrapper.m_ChoiceActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IChoiceActions instance)
        {
            foreach (var item in m_Wrapper.m_ChoiceActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ChoiceActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ChoiceActions @Choice => new ChoiceActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_JoyStickSchemeIndex = -1;
    public InputControlScheme JoyStickScheme
    {
        get
        {
            if (m_JoyStickSchemeIndex == -1) m_JoyStickSchemeIndex = asset.FindControlSchemeIndex("JoyStick");
            return asset.controlSchemes[m_JoyStickSchemeIndex];
        }
    }
    public interface IPedastrainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IChoiceActions
    {
        void OnConfirm(InputAction.CallbackContext context);
    }
}
