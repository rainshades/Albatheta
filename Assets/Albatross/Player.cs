// GENERATED AUTOMATICALLY FROM 'Assets/Albatross/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""CommandMenu"",
            ""id"": ""db14a3ee-141e-417a-8bbc-a907a67b5929"",
            ""actions"": [
                {
                    ""name"": ""Command Menu Cycle"",
                    ""type"": ""Button"",
                    ""id"": ""1890a3c5-d3b6-4b72-a376-6bcacde69b9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterCommand"",
                    ""type"": ""Button"",
                    ""id"": ""5d83c5c5-2e29-4072-98b4-de02018342d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9495db8e-db70-4ad7-a117-0fb3a6e6f2d7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""333d059f-ca49-470e-aa9a-6724490853fa"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""85353775-4513-4618-a835-f3ea6cfe06df"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a24afa7c-7d9e-4146-b6a9-092b16c02051"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""153d34f9-e079-42ff-b692-1e135ce490e0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c0bc5870-3885-426f-8e6d-6df68e063bd0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command Menu Cycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""20e18dd3-3f29-482f-82a9-58aa9a2db45a"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterCommand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0182e5cc-21b0-4e15-92a7-ac0c578dc05d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterCommand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControls"",
            ""id"": ""5de229e9-93ff-4493-86d7-669aa62fad70"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""21aa5560-0446-4b60-b977-4d6a2381d9d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3f62e0d9-e7d8-4ce9-88de-011caf104eee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""e1d04a97-b210-4a30-ae13-a4340529aa9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""bc91efc1-fca4-4c8e-ad36-45edcbf97662"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fcdcec06-4a18-4ccc-9245-c412bf31bcab"",
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
                    ""id"": ""18a01ec2-b14f-4f53-9497-a63e10e33361"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ea92c807-603a-46b9-a7ce-88272098621f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""44f81bf8-9286-4d55-9b1e-fcb89face97a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fde8fa02-b6cd-468e-88a2-958ae8bfca33"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""77aafa5b-f607-493b-b495-5a833c910b58"",
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
                    ""id"": ""9d3a3cb0-6c3a-45b2-b2a3-58b283e14910"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad7a42f1-6dba-474b-be34-cbe4b8b63e8a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3f52e8ae-ecca-488d-88c9-08282ca5376c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""332f1920-5454-4a29-9546-7cc66c7a34a9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3804c420-607b-47df-a31d-84f997e27994"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e1e7264-1996-4240-af95-2fa9f502be46"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bfcc1bd-7d8f-4dfb-b72c-49dd7fcd869b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7faf79a7-2026-482f-bde6-e5aa3e6db7f1"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57412f90-700c-4f90-8669-3dc806f90024"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7026d8a-b8c6-42fd-bcf4-1484dfca0292"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraControls"",
            ""id"": ""3b710508-64b6-4ac8-bda7-96375db3e57e"",
            ""actions"": [
                {
                    ""name"": ""CameraLock"",
                    ""type"": ""Button"",
                    ""id"": ""356f6383-5811-4f49-aeee-e345eeb0424b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Button"",
                    ""id"": ""421eb4a4-896a-4fe7-9d64-c7bead2c0766"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dda4a5ed-473c-462a-b2a5-583ec6136d9c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6f9a711-87d6-4b48-9567-06aa489a6809"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f9a5bf4b-7896-4282-a6fd-29a951cffbac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6eb9ea9e-0169-49ee-b2ae-d082d44d6aa5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""26c25f8f-fe56-498a-9fe5-fb044915d81c"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d75f2de7-218c-408f-b586-be055dd24212"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""70fc4919-d6ac-4f90-a6be-750a3ae4079b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5d34c146-e57a-44da-8331-f19dd2c1d3c2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b72da608-547e-4f6b-9b92-c5857222abaa"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7524bc54-2e6e-4930-b3dc-84fce9e6821d"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""23b6bfa3-4e2a-417a-a137-dda3f8809f57"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""53b5be68-06b3-4597-abc3-528637960d1a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CommandMenu
        m_CommandMenu = asset.FindActionMap("CommandMenu", throwIfNotFound: true);
        m_CommandMenu_CommandMenuCycle = m_CommandMenu.FindAction("Command Menu Cycle", throwIfNotFound: true);
        m_CommandMenu_EnterCommand = m_CommandMenu.FindAction("EnterCommand", throwIfNotFound: true);
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Block = m_PlayerControls.FindAction("Block", throwIfNotFound: true);
        m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
        // CameraControls
        m_CameraControls = asset.FindActionMap("CameraControls", throwIfNotFound: true);
        m_CameraControls_CameraLock = m_CameraControls.FindAction("CameraLock", throwIfNotFound: true);
        m_CameraControls_CameraMove = m_CameraControls.FindAction("CameraMove", throwIfNotFound: true);
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

    // CommandMenu
    private readonly InputActionMap m_CommandMenu;
    private ICommandMenuActions m_CommandMenuActionsCallbackInterface;
    private readonly InputAction m_CommandMenu_CommandMenuCycle;
    private readonly InputAction m_CommandMenu_EnterCommand;
    public struct CommandMenuActions
    {
        private @Player m_Wrapper;
        public CommandMenuActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @CommandMenuCycle => m_Wrapper.m_CommandMenu_CommandMenuCycle;
        public InputAction @EnterCommand => m_Wrapper.m_CommandMenu_EnterCommand;
        public InputActionMap Get() { return m_Wrapper.m_CommandMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CommandMenuActions set) { return set.Get(); }
        public void SetCallbacks(ICommandMenuActions instance)
        {
            if (m_Wrapper.m_CommandMenuActionsCallbackInterface != null)
            {
                @CommandMenuCycle.started -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnCommandMenuCycle;
                @CommandMenuCycle.performed -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnCommandMenuCycle;
                @CommandMenuCycle.canceled -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnCommandMenuCycle;
                @EnterCommand.started -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnEnterCommand;
                @EnterCommand.performed -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnEnterCommand;
                @EnterCommand.canceled -= m_Wrapper.m_CommandMenuActionsCallbackInterface.OnEnterCommand;
            }
            m_Wrapper.m_CommandMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CommandMenuCycle.started += instance.OnCommandMenuCycle;
                @CommandMenuCycle.performed += instance.OnCommandMenuCycle;
                @CommandMenuCycle.canceled += instance.OnCommandMenuCycle;
                @EnterCommand.started += instance.OnEnterCommand;
                @EnterCommand.performed += instance.OnEnterCommand;
                @EnterCommand.canceled += instance.OnEnterCommand;
            }
        }
    }
    public CommandMenuActions @CommandMenu => new CommandMenuActions(this);

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Block;
    private readonly InputAction m_PlayerControls_Pause;
    public struct PlayerControlsActions
    {
        private @Player m_Wrapper;
        public PlayerControlsActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Block => m_Wrapper.m_PlayerControls_Block;
        public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Block.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnBlock;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // CameraControls
    private readonly InputActionMap m_CameraControls;
    private ICameraControlsActions m_CameraControlsActionsCallbackInterface;
    private readonly InputAction m_CameraControls_CameraLock;
    private readonly InputAction m_CameraControls_CameraMove;
    public struct CameraControlsActions
    {
        private @Player m_Wrapper;
        public CameraControlsActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLock => m_Wrapper.m_CameraControls_CameraLock;
        public InputAction @CameraMove => m_Wrapper.m_CameraControls_CameraMove;
        public InputActionMap Get() { return m_Wrapper.m_CameraControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICameraControlsActions instance)
        {
            if (m_Wrapper.m_CameraControlsActionsCallbackInterface != null)
            {
                @CameraLock.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraLock;
                @CameraLock.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraLock;
                @CameraLock.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraLock;
                @CameraMove.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraMove;
            }
            m_Wrapper.m_CameraControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraLock.started += instance.OnCameraLock;
                @CameraLock.performed += instance.OnCameraLock;
                @CameraLock.canceled += instance.OnCameraLock;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
            }
        }
    }
    public CameraControlsActions @CameraControls => new CameraControlsActions(this);
    public interface ICommandMenuActions
    {
        void OnCommandMenuCycle(InputAction.CallbackContext context);
        void OnEnterCommand(InputAction.CallbackContext context);
    }
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface ICameraControlsActions
    {
        void OnCameraLock(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
    }
}
