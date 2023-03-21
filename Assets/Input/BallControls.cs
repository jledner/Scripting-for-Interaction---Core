//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/BallControls.inputactions
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

public partial class @BallControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BallControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BallControls"",
    ""maps"": [
        {
            ""name"": ""Roll-a-ball Controls"",
            ""id"": ""e92ee51b-e1a6-4b96-96f8-824dff94902f"",
            ""actions"": [
                {
                    ""name"": ""BallRoll"",
                    ""type"": ""Value"",
                    ""id"": ""801a5dba-46ad-41bd-a810-64536b48c0ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""a44cbebd-5c9a-4955-9166-82f295828202"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6c551bda-ef1d-4041-9679-42250d62ebc9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BallRoll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9225dec0-79c6-4424-ab43-8cddfa13cee0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b935a120-07ac-4ea8-8308-cab217a8d417"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12396646-9c1a-485b-a123-2e99fcaf505c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b551800-b292-4816-8c92-c4d9f59cb31e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow keys"",
                    ""id"": ""f6a40e2c-d06e-4197-99ab-e4989f0792cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BallRoll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""64bef3ac-1446-41aa-909f-e234fd667168"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8e9dc8c8-9126-493a-b9fa-edbf9a7ebe64"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""92a61511-9c75-4f2a-b3e8-d890896eb157"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a78c8183-2293-4934-9a20-b7ebd01cb6c7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BallRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b5ff16bf-c0c3-4eaa-aa5e-212529405bd0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Roll-a-ball Controls
        m_RollaballControls = asset.FindActionMap("Roll-a-ball Controls", throwIfNotFound: true);
        m_RollaballControls_BallRoll = m_RollaballControls.FindAction("BallRoll", throwIfNotFound: true);
        m_RollaballControls_CameraLook = m_RollaballControls.FindAction("CameraLook", throwIfNotFound: true);
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

    // Roll-a-ball Controls
    private readonly InputActionMap m_RollaballControls;
    private IRollaballControlsActions m_RollaballControlsActionsCallbackInterface;
    private readonly InputAction m_RollaballControls_BallRoll;
    private readonly InputAction m_RollaballControls_CameraLook;
    public struct RollaballControlsActions
    {
        private @BallControls m_Wrapper;
        public RollaballControlsActions(@BallControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @BallRoll => m_Wrapper.m_RollaballControls_BallRoll;
        public InputAction @CameraLook => m_Wrapper.m_RollaballControls_CameraLook;
        public InputActionMap Get() { return m_Wrapper.m_RollaballControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RollaballControlsActions set) { return set.Get(); }
        public void SetCallbacks(IRollaballControlsActions instance)
        {
            if (m_Wrapper.m_RollaballControlsActionsCallbackInterface != null)
            {
                @BallRoll.started -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnBallRoll;
                @BallRoll.performed -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnBallRoll;
                @BallRoll.canceled -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnBallRoll;
                @CameraLook.started -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnCameraLook;
                @CameraLook.performed -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnCameraLook;
                @CameraLook.canceled -= m_Wrapper.m_RollaballControlsActionsCallbackInterface.OnCameraLook;
            }
            m_Wrapper.m_RollaballControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BallRoll.started += instance.OnBallRoll;
                @BallRoll.performed += instance.OnBallRoll;
                @BallRoll.canceled += instance.OnBallRoll;
                @CameraLook.started += instance.OnCameraLook;
                @CameraLook.performed += instance.OnCameraLook;
                @CameraLook.canceled += instance.OnCameraLook;
            }
        }
    }
    public RollaballControlsActions @RollaballControls => new RollaballControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IRollaballControlsActions
    {
        void OnBallRoll(InputAction.CallbackContext context);
        void OnCameraLook(InputAction.CallbackContext context);
    }
}
