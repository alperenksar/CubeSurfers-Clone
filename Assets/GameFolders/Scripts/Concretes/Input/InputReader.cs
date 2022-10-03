using CubeSurfersClone.Abstracts.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CubeSurfersClone.Inputs
{
    public class InputReader : MonoBehaviour ,IInputReader
    {
        public Vector3 Direction { get; private set; }

        public void OnMove(InputAction.CallbackContext context)
        {
            Vector2 tempDirection = context.ReadValue<Vector2>();
            Direction = new Vector3(0f, 0f, tempDirection.x);
           
        }
    }

}

