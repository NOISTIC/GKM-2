//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.13.0
//     from Assets/Input/CharacterController.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/CharacterController.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @CharacterController: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @CharacterController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterController"",
    ""maps"": [
        {
            ""name"": ""Controller"",
            ""id"": ""1de5a57f-fa90-460d-bdc3-7e8710027dbc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""ece5fa93-60c8-4008-988b-cd540e404cad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""515cac30-7d01-4b93-9ee8-558984ac5880"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5964b5ab-1ae3-4bbb-a675-be4dc56d1cd1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4868db4-889d-48d3-9b1d-b83887dfdc7e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a2d58bfd-4dff-47a0-a9f6-d2891daae77a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""346d9aa5-32b7-4ff3-9d45-ad9a4a361562"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1091d58a-0339-44e6-aa2d-68eedf346dcb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4f86ce8d-f11d-465a-99db-fbbdc327c641"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a948365-336a-4f72-9761-2d3409921f41"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""23cde8d0-f136-45a3-97d1-a6f35d1243dc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c3e9a6-e720-43df-99f4-1cf866a4599d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5d4381d-9d98-4f2b-9b9f-90f05beceb12"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bbfdb03-a8a4-4672-a94f-33f912224768"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
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
        // Controller
        m_Controller = asset.FindActionMap("Controller", throwIfNotFound: true);
        m_Controller_Movement = m_Controller.FindAction("Movement", throwIfNotFound: true);
        m_Controller_Look = m_Controller.FindAction("Look", throwIfNotFound: true);
        m_Controller_Jump = m_Controller.FindAction("Jump", throwIfNotFound: true);
    }

    ~@CharacterController()
    {
        UnityEngine.Debug.Assert(!m_Controller.enabled, "This will cause a leak and performance issues, CharacterController.Controller.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Controller
    private readonly InputActionMap m_Controller;
    private List<IControllerActions> m_ControllerActionsCallbackInterfaces = new List<IControllerActions>();
    private readonly InputAction m_Controller_Movement;
    private readonly InputAction m_Controller_Look;
    private readonly InputAction m_Controller_Jump;
    /// <summary>
    /// Provides access to input actions defined in input action map "Controller".
    /// </summary>
    public struct ControllerActions
    {
        private @CharacterController m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public ControllerActions(@CharacterController wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Controller/Movement".
        /// </summary>
        public InputAction @Movement => m_Wrapper.m_Controller_Movement;
        /// <summary>
        /// Provides access to the underlying input action "Controller/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Controller_Look;
        /// <summary>
        /// Provides access to the underlying input action "Controller/Jump".
        /// </summary>
        public InputAction @Jump => m_Wrapper.m_Controller_Jump;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Controller; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="ControllerActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(ControllerActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="ControllerActions" />
        public void AddCallbacks(IControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_ControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControllerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="ControllerActions" />
        private void UnregisterCallbacks(IControllerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="ControllerActions.UnregisterCallbacks(IControllerActions)" />.
        /// </summary>
        /// <seealso cref="ControllerActions.UnregisterCallbacks(IControllerActions)" />
        public void RemoveCallbacks(IControllerActions instance)
        {
            if (m_Wrapper.m_ControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="ControllerActions.AddCallbacks(IControllerActions)" />
        /// <seealso cref="ControllerActions.RemoveCallbacks(IControllerActions)" />
        /// <seealso cref="ControllerActions.UnregisterCallbacks(IControllerActions)" />
        public void SetCallbacks(IControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_ControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="ControllerActions" /> instance referencing this action map.
    /// </summary>
    public ControllerActions @Controller => new ControllerActions(this);
    private int m_ControllerSchemeIndex = -1;
    /// <summary>
    /// Provides access to the input control scheme.
    /// </summary>
    /// <seealso cref="UnityEngine.InputSystem.InputControlScheme" />
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    /// <summary>
    /// Provides access to the input control scheme.
    /// </summary>
    /// <seealso cref="UnityEngine.InputSystem.InputControlScheme" />
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Controller" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="ControllerActions.AddCallbacks(IControllerActions)" />
    /// <seealso cref="ControllerActions.RemoveCallbacks(IControllerActions)" />
    public interface IControllerActions
    {
        /// <summary>
        /// Method invoked when associated input action "Movement" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMovement(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Jump" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnJump(InputAction.CallbackContext context);
    }
}
