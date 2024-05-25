using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IdaGameJam.Core.Input;
using IdaGameJam.Core.SO;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using System;

namespace IdaGameJam.Core.Input
{
    [CreateAssetMenu(fileName = "New Input", menuName = "Game Input")]
    public class InputHandler : DescriptionBaseSO,Controller.IPlayerActions
    {
        Controller _controller; 
        
        public event UnityAction<Vector2> MoveEvent = delegate{};
        public event UnityAction JumpEvent = delegate{};

        void OnEnable()
        {
            if(_controller == null)
            {
                _controller = new Controller();

                //Setting callbacks
                _controller.Player.SetCallbacks(this);
            }

            _controller.Player.Enable();
        }
        public void OnMove(InputAction.CallbackContext context)
        {
            MoveEvent.Invoke(context.ReadValue<Vector2>());
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            //Debug.Log(context);
            if(context.phase != InputActionPhase.Performed)return;
            JumpEvent.Invoke();
        }

        void OnDisable()
        {
            _controller.Player.Disable();
        }
    }

}
