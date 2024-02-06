//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Attack.inputactions
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

public partial class @Attack: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Attack()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Attack"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""20a35cfb-66c1-4529-b7f7-88206856699b"",
            ""actions"": [
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""78d08129-8fdf-40ff-b1fd-1669d1989cbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lasor"",
                    ""type"": ""Button"",
                    ""id"": ""43c7091e-329f-40c3-a93f-2e2f4b21c936"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6cdfaf36-1b99-4c36-ba97-d4fb419a7ccb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""224f281f-2fb4-4949-bd8e-797f7cccd191"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lasor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_attack = m_player.FindAction("attack", throwIfNotFound: true);
        m_player_lasor = m_player.FindAction("lasor", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_player_attack;
    private readonly InputAction m_player_lasor;
    public struct PlayerActions
    {
        private @Attack m_Wrapper;
        public PlayerActions(@Attack wrapper) { m_Wrapper = wrapper; }
        public InputAction @attack => m_Wrapper.m_player_attack;
        public InputAction @lasor => m_Wrapper.m_player_lasor;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @attack.started += instance.OnAttack;
            @attack.performed += instance.OnAttack;
            @attack.canceled += instance.OnAttack;
            @lasor.started += instance.OnLasor;
            @lasor.performed += instance.OnLasor;
            @lasor.canceled += instance.OnLasor;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @attack.started -= instance.OnAttack;
            @attack.performed -= instance.OnAttack;
            @attack.canceled -= instance.OnAttack;
            @lasor.started -= instance.OnLasor;
            @lasor.performed -= instance.OnLasor;
            @lasor.canceled -= instance.OnLasor;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnLasor(InputAction.CallbackContext context);
    }
}