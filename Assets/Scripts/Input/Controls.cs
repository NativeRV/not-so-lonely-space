// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace NSLS.Game.Input
{
    public class @Controls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3f837a61-7144-4e48-aa50-3dc28d7ba7da"",
            ""actions"": [
                {
                    ""name"": ""PlayerCameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""9c39266f-feee-469d-bf7b-4c032b86a3d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerHorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""d26f3369-22cc-40d8-ac73-6b5ae1d5dc37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerJump"",
                    ""type"": ""Button"",
                    ""id"": ""21166a95-3d25-4ee5-9e3b-9d6d2ec88b46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerLeftHandUse"",
                    ""type"": ""Button"",
                    ""id"": ""090ebe0e-e9cb-4892-b869-a1c4b19d6cdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13b3ef38-87a6-43a1-83b7-c336dd7e4478"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerCameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9013281e-20f4-428b-a76f-bf9f08593a68"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerHorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4b067ea9-becf-453d-8f9c-8d8812b2eba1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerHorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2733e0d2-6583-4948-833e-5a20f6b43f65"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerHorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3e8e91eb-dafe-42a1-8e1d-a90a9eb10e54"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerHorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0badeb49-e1b3-47fd-b4a7-8a75066bb075"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerHorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f50a8ea2-4d11-4bd1-83db-1c3aebdcb27e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2928d7ce-f59f-4267-995a-6ad653959944"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHandUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_PlayerCameraLook = m_Player.FindAction("PlayerCameraLook", throwIfNotFound: true);
            m_Player_PlayerHorizontalMovement = m_Player.FindAction("PlayerHorizontalMovement", throwIfNotFound: true);
            m_Player_PlayerJump = m_Player.FindAction("PlayerJump", throwIfNotFound: true);
      m_Player_PlayerLeftHandUse = m_Player.FindAction("PlayerLeftHandUse", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_PlayerCameraLook;
        private readonly InputAction m_Player_PlayerHorizontalMovement;
        private readonly InputAction m_Player_PlayerJump;
    private readonly InputAction m_Player_PlayerLeftHandUse;
        public struct PlayerActions
        {
            private @Controls m_Wrapper;
            public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @PlayerCameraLook => m_Wrapper.m_Player_PlayerCameraLook;
            public InputAction @PlayerHorizontalMovement => m_Wrapper.m_Player_PlayerHorizontalMovement;
            public InputAction @PlayerJump => m_Wrapper.m_Player_PlayerJump;
      public InputAction @PlayerLeftHandUse => m_Wrapper.m_Player_PlayerLeftHandUse;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @PlayerCameraLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerCameraLook;
                    @PlayerCameraLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerCameraLook;
                    @PlayerCameraLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerCameraLook;
                    @PlayerHorizontalMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                    @PlayerJump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
                    @PlayerJump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
                    @PlayerJump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerJump;
          @PlayerLeftHandUse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerLeftHandUse;
          @PlayerLeftHandUse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerLeftHandUse;
          @PlayerLeftHandUse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerLeftHandUse;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PlayerCameraLook.started += instance.OnPlayerCameraLook;
                    @PlayerCameraLook.performed += instance.OnPlayerCameraLook;
                    @PlayerCameraLook.canceled += instance.OnPlayerCameraLook;
                    @PlayerHorizontalMovement.started += instance.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.performed += instance.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.canceled += instance.OnPlayerHorizontalMovement;
                    @PlayerJump.started += instance.OnPlayerJump;
                    @PlayerJump.performed += instance.OnPlayerJump;
                    @PlayerJump.canceled += instance.OnPlayerJump;
          @PlayerLeftHandUse.started += instance.OnPlayerLeftHandUse;
          @PlayerLeftHandUse.performed += instance.OnPlayerLeftHandUse;
          @PlayerLeftHandUse.canceled += instance.OnPlayerLeftHandUse;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnPlayerCameraLook(InputAction.CallbackContext context);
            void OnPlayerHorizontalMovement(InputAction.CallbackContext context);
            void OnPlayerJump(InputAction.CallbackContext context);
      void OnPlayerLeftHandUse(InputAction.CallbackContext context);
        }
    }
}
