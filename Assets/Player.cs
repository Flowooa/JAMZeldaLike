//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
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

public partial class @Player : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""dbc6b5b2-e984-4829-97df-8007661fe988"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c45f530f-e720-4285-aef0-6acec5ec6511"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fd31a7ab-ee7d-455f-bf13-a387ed639847"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""895d793c-8648-41a2-8c26-3296c562bc24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackUp"",
                    ""type"": ""Button"",
                    ""id"": ""cc2712d2-05cc-4e4d-87f7-89245532b93e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackDown"",
                    ""type"": ""Button"",
                    ""id"": ""0c7fc04c-9a7c-4b5f-bfc8-3715eb72d697"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackLeft"",
                    ""type"": ""Button"",
                    ""id"": ""77f47c67-487f-4c71-b10a-ca8af5fd8880"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackRight"",
                    ""type"": ""Button"",
                    ""id"": ""577eb16f-6228-49cc-b778-2fc8ee42c3b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""39e3a1c7-b141-4f6e-9f19-7ca4c706e048"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90e7ed07-9629-4913-a188-edbc36f69f90"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keybord"",
                    ""id"": ""255e8ba2-5b2c-472d-a0f5-ff8eaad32035"",
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
                    ""id"": ""ea4bb0f1-8806-413e-8273-8a4d9fa3cc4d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f5934c1-e88d-4ce6-a757-d57057fdc34e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b351e3c2-f528-4b9f-b089-f223e23f1da9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d082496a-76fc-4c51-b5ab-332f867c67da"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""e4bfe2ad-3d61-466e-a55c-020eb294f231"",
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
                    ""id"": ""3753a8e3-d38b-489e-95c8-abf375c4b0d0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""576b643a-18fc-4f11-a01c-cb1e0ae26f0d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""618d4152-dd2b-49a1-b523-e34ef028d941"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee049978-b9e2-4cf8-85e0-7eeacdc9eed2"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f4de9dc9-a97b-44a1-808a-25c8b9bfbdc7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c59e872-8b55-445f-9003-f3b4ded3e664"",
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
                    ""id"": ""6c36d056-58ed-4ccc-abcc-31dce1c6ac2c"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d72cafbc-7a99-44ae-98f1-54b8aa9cd15b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f224138-8047-4e10-b803-b33a282d51ff"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7ec5d75-b8dd-4123-8326-8e1640037252"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""885596b0-7cac-4268-bac7-25a681b2d019"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""585cfb6c-5561-4c9a-af77-1f9c5e4f1b2d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1651121-4add-44a9-a88c-74dcd23b281c"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95623f71-b584-43c3-9489-6a859abed123"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ManettePlayerMenu"",
            ""id"": ""cd8b4cd9-2aa4-485f-8f2e-fa4294d0eb78"",
            ""actions"": [
                {
                    ""name"": ""GameStart"",
                    ""type"": ""Button"",
                    ""id"": ""e0a19c54-d010-4fb9-8e67-441813733310"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExitGame"",
                    ""type"": ""Button"",
                    ""id"": ""158f4fa4-bfde-4ae2-a032-898d1f199d14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AreYouSureY"",
                    ""type"": ""Button"",
                    ""id"": ""c43e9698-5173-4098-92b4-6855bfaaabcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AreYouSureN"",
                    ""type"": ""Button"",
                    ""id"": ""b4281dcd-7203-4671-b492-306e738faee8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62e2cfe3-fff6-4b97-a6d1-9b0c2715dbb6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GameStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3059915b-7048-41cc-98c4-667138d0fc8b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4170d304-f077-489f-af0b-0489e5650cba"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AreYouSureY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""816a0a2d-99b2-4023-b56b-4632befe9a31"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AreYouSureN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Attack = m_PlayerMovement.FindAction("Attack", throwIfNotFound: true);
        m_PlayerMovement_Move = m_PlayerMovement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovement_Pause = m_PlayerMovement.FindAction("Pause", throwIfNotFound: true);
        m_PlayerMovement_AttackUp = m_PlayerMovement.FindAction("AttackUp", throwIfNotFound: true);
        m_PlayerMovement_AttackDown = m_PlayerMovement.FindAction("AttackDown", throwIfNotFound: true);
        m_PlayerMovement_AttackLeft = m_PlayerMovement.FindAction("AttackLeft", throwIfNotFound: true);
        m_PlayerMovement_AttackRight = m_PlayerMovement.FindAction("AttackRight", throwIfNotFound: true);
        // ManettePlayerMenu
        m_ManettePlayerMenu = asset.FindActionMap("ManettePlayerMenu", throwIfNotFound: true);
        m_ManettePlayerMenu_GameStart = m_ManettePlayerMenu.FindAction("GameStart", throwIfNotFound: true);
        m_ManettePlayerMenu_ExitGame = m_ManettePlayerMenu.FindAction("ExitGame", throwIfNotFound: true);
        m_ManettePlayerMenu_AreYouSureY = m_ManettePlayerMenu.FindAction("AreYouSureY", throwIfNotFound: true);
        m_ManettePlayerMenu_AreYouSureN = m_ManettePlayerMenu.FindAction("AreYouSureN", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Attack;
    private readonly InputAction m_PlayerMovement_Move;
    private readonly InputAction m_PlayerMovement_Pause;
    private readonly InputAction m_PlayerMovement_AttackUp;
    private readonly InputAction m_PlayerMovement_AttackDown;
    private readonly InputAction m_PlayerMovement_AttackLeft;
    private readonly InputAction m_PlayerMovement_AttackRight;
    public struct PlayerMovementActions
    {
        private @Player m_Wrapper;
        public PlayerMovementActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_PlayerMovement_Attack;
        public InputAction @Move => m_Wrapper.m_PlayerMovement_Move;
        public InputAction @Pause => m_Wrapper.m_PlayerMovement_Pause;
        public InputAction @AttackUp => m_Wrapper.m_PlayerMovement_AttackUp;
        public InputAction @AttackDown => m_Wrapper.m_PlayerMovement_AttackDown;
        public InputAction @AttackLeft => m_Wrapper.m_PlayerMovement_AttackLeft;
        public InputAction @AttackRight => m_Wrapper.m_PlayerMovement_AttackRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttack;
                @Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Pause.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @AttackUp.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackUp;
                @AttackUp.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackUp;
                @AttackUp.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackUp;
                @AttackDown.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackDown;
                @AttackDown.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackDown;
                @AttackDown.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackDown;
                @AttackLeft.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackLeft;
                @AttackLeft.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackLeft;
                @AttackLeft.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackLeft;
                @AttackRight.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackRight;
                @AttackRight.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackRight;
                @AttackRight.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAttackRight;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @AttackUp.started += instance.OnAttackUp;
                @AttackUp.performed += instance.OnAttackUp;
                @AttackUp.canceled += instance.OnAttackUp;
                @AttackDown.started += instance.OnAttackDown;
                @AttackDown.performed += instance.OnAttackDown;
                @AttackDown.canceled += instance.OnAttackDown;
                @AttackLeft.started += instance.OnAttackLeft;
                @AttackLeft.performed += instance.OnAttackLeft;
                @AttackLeft.canceled += instance.OnAttackLeft;
                @AttackRight.started += instance.OnAttackRight;
                @AttackRight.performed += instance.OnAttackRight;
                @AttackRight.canceled += instance.OnAttackRight;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // ManettePlayerMenu
    private readonly InputActionMap m_ManettePlayerMenu;
    private IManettePlayerMenuActions m_ManettePlayerMenuActionsCallbackInterface;
    private readonly InputAction m_ManettePlayerMenu_GameStart;
    private readonly InputAction m_ManettePlayerMenu_ExitGame;
    private readonly InputAction m_ManettePlayerMenu_AreYouSureY;
    private readonly InputAction m_ManettePlayerMenu_AreYouSureN;
    public struct ManettePlayerMenuActions
    {
        private @Player m_Wrapper;
        public ManettePlayerMenuActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @GameStart => m_Wrapper.m_ManettePlayerMenu_GameStart;
        public InputAction @ExitGame => m_Wrapper.m_ManettePlayerMenu_ExitGame;
        public InputAction @AreYouSureY => m_Wrapper.m_ManettePlayerMenu_AreYouSureY;
        public InputAction @AreYouSureN => m_Wrapper.m_ManettePlayerMenu_AreYouSureN;
        public InputActionMap Get() { return m_Wrapper.m_ManettePlayerMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManettePlayerMenuActions set) { return set.Get(); }
        public void SetCallbacks(IManettePlayerMenuActions instance)
        {
            if (m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface != null)
            {
                @GameStart.started -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnGameStart;
                @GameStart.performed -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnGameStart;
                @GameStart.canceled -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnGameStart;
                @ExitGame.started -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnExitGame;
                @AreYouSureY.started -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureY;
                @AreYouSureY.performed -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureY;
                @AreYouSureY.canceled -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureY;
                @AreYouSureN.started -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureN;
                @AreYouSureN.performed -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureN;
                @AreYouSureN.canceled -= m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface.OnAreYouSureN;
            }
            m_Wrapper.m_ManettePlayerMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GameStart.started += instance.OnGameStart;
                @GameStart.performed += instance.OnGameStart;
                @GameStart.canceled += instance.OnGameStart;
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
                @AreYouSureY.started += instance.OnAreYouSureY;
                @AreYouSureY.performed += instance.OnAreYouSureY;
                @AreYouSureY.canceled += instance.OnAreYouSureY;
                @AreYouSureN.started += instance.OnAreYouSureN;
                @AreYouSureN.performed += instance.OnAreYouSureN;
                @AreYouSureN.canceled += instance.OnAreYouSureN;
            }
        }
    }
    public ManettePlayerMenuActions @ManettePlayerMenu => new ManettePlayerMenuActions(this);
    public interface IPlayerMovementActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnAttackUp(InputAction.CallbackContext context);
        void OnAttackDown(InputAction.CallbackContext context);
        void OnAttackLeft(InputAction.CallbackContext context);
        void OnAttackRight(InputAction.CallbackContext context);
    }
    public interface IManettePlayerMenuActions
    {
        void OnGameStart(InputAction.CallbackContext context);
        void OnExitGame(InputAction.CallbackContext context);
        void OnAreYouSureY(InputAction.CallbackContext context);
        void OnAreYouSureN(InputAction.CallbackContext context);
    }
}
