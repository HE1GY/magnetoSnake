// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Snake"",
            ""id"": ""9aa38211-c2ad-4719-8e8b-280a2e3f74d6"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""5586d8c6-e3b9-4a53-870b-853659d06b62"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2efe919c-f9e4-4b46-9401-3ec6f36410fd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""c0c6fe4a-e196-49e3-afc6-adf9195be871"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""b6102970-eb87-4cd2-9997-667ee475c891"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Snake
        m_Snake = asset.FindActionMap("Snake", throwIfNotFound: true);
        m_Snake_Rotate = m_Snake.FindAction("Rotate", throwIfNotFound: true);
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

    // Snake
    private readonly InputActionMap m_Snake;
    private ISnakeActions m_SnakeActionsCallbackInterface;
    private readonly InputAction m_Snake_Rotate;
    public struct SnakeActions
    {
        private @PlayerInput m_Wrapper;
        public SnakeActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Snake_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Snake; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SnakeActions set) { return set.Get(); }
        public void SetCallbacks(ISnakeActions instance)
        {
            if (m_Wrapper.m_SnakeActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_SnakeActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_SnakeActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_SnakeActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_SnakeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public SnakeActions @Snake => new SnakeActions(this);
    public interface ISnakeActions
    {
        void OnRotate(InputAction.CallbackContext context);
    }
}
