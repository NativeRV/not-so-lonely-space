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
                    ""name"": ""PlayerMoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""c725bd58-1529-40c9-ada2-94d87c20c268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMoveBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""9b3ecf34-c2aa-428a-ad24-1e9d7848c448"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerStrafeLeft"",
                    ""type"": ""Button"",
                    ""id"": ""96fc2174-2c9d-44e9-bbba-338ec522b345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerStrafeRight"",
                    ""type"": ""Button"",
                    ""id"": ""08d6a725-be36-423a-8854-a4856057e346"",
                    ""expectedControlType"": ""Button"",
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
                    ""name"": """",
                    ""id"": ""d78ddb9c-6785-4c02-a47d-dfe46f549d9b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerMoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78b36a73-32dd-4b81-ba97-2deec8b9bdad"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerMoveBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f094ab-096a-4d36-b915-2fe7852bbc69"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerStrafeLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19060d3d-3c67-4839-8d3e-486929b8c20f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlayerStrafeRight"",
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
            m_Player_PlayerMoveForward = m_Player.FindAction("PlayerMoveForward", throwIfNotFound: true);
            m_Player_PlayerMoveBackwards = m_Player.FindAction("PlayerMoveBackwards", throwIfNotFound: true);
            m_Player_PlayerStrafeLeft = m_Player.FindAction("PlayerStrafeLeft", throwIfNotFound: true);
            m_Player_PlayerStrafeRight = m_Player.FindAction("PlayerStrafeRight", throwIfNotFound: true);
            m_Player_PlayerHorizontalMovement = m_Player.FindAction("PlayerHorizontalMovement", throwIfNotFound: true);
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
        private readonly InputAction m_Player_PlayerMoveForward;
        private readonly InputAction m_Player_PlayerMoveBackwards;
        private readonly InputAction m_Player_PlayerStrafeLeft;
        private readonly InputAction m_Player_PlayerStrafeRight;
        private readonly InputAction m_Player_PlayerHorizontalMovement;
        public struct PlayerActions
        {
            private @Controls m_Wrapper;
            public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @PlayerCameraLook => m_Wrapper.m_Player_PlayerCameraLook;
            public InputAction @PlayerMoveForward => m_Wrapper.m_Player_PlayerMoveForward;
            public InputAction @PlayerMoveBackwards => m_Wrapper.m_Player_PlayerMoveBackwards;
            public InputAction @PlayerStrafeLeft => m_Wrapper.m_Player_PlayerStrafeLeft;
            public InputAction @PlayerStrafeRight => m_Wrapper.m_Player_PlayerStrafeRight;
            public InputAction @PlayerHorizontalMovement => m_Wrapper.m_Player_PlayerHorizontalMovement;
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
                    @PlayerMoveForward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveForward;
                    @PlayerMoveForward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveForward;
                    @PlayerMoveForward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveForward;
                    @PlayerMoveBackwards.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveBackwards;
                    @PlayerMoveBackwards.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveBackwards;
                    @PlayerMoveBackwards.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerMoveBackwards;
                    @PlayerStrafeLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeLeft;
                    @PlayerStrafeLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeLeft;
                    @PlayerStrafeLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeLeft;
                    @PlayerStrafeRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeRight;
                    @PlayerStrafeRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeRight;
                    @PlayerStrafeRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerStrafeRight;
                    @PlayerHorizontalMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayerHorizontalMovement;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PlayerCameraLook.started += instance.OnPlayerCameraLook;
                    @PlayerCameraLook.performed += instance.OnPlayerCameraLook;
                    @PlayerCameraLook.canceled += instance.OnPlayerCameraLook;
                    @PlayerMoveForward.started += instance.OnPlayerMoveForward;
                    @PlayerMoveForward.performed += instance.OnPlayerMoveForward;
                    @PlayerMoveForward.canceled += instance.OnPlayerMoveForward;
                    @PlayerMoveBackwards.started += instance.OnPlayerMoveBackwards;
                    @PlayerMoveBackwards.performed += instance.OnPlayerMoveBackwards;
                    @PlayerMoveBackwards.canceled += instance.OnPlayerMoveBackwards;
                    @PlayerStrafeLeft.started += instance.OnPlayerStrafeLeft;
                    @PlayerStrafeLeft.performed += instance.OnPlayerStrafeLeft;
                    @PlayerStrafeLeft.canceled += instance.OnPlayerStrafeLeft;
                    @PlayerStrafeRight.started += instance.OnPlayerStrafeRight;
                    @PlayerStrafeRight.performed += instance.OnPlayerStrafeRight;
                    @PlayerStrafeRight.canceled += instance.OnPlayerStrafeRight;
                    @PlayerHorizontalMovement.started += instance.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.performed += instance.OnPlayerHorizontalMovement;
                    @PlayerHorizontalMovement.canceled += instance.OnPlayerHorizontalMovement;
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
            void OnPlayerMoveForward(InputAction.CallbackContext context);
            void OnPlayerMoveBackwards(InputAction.CallbackContext context);
            void OnPlayerStrafeLeft(InputAction.CallbackContext context);
            void OnPlayerStrafeRight(InputAction.CallbackContext context);
            void OnPlayerHorizontalMovement(InputAction.CallbackContext context);
        }
    }
}
