using CubeSurfers.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Movement
{
    public class BoxHorizontalMovementMouse : MonoBehaviour
    {
        PlayerController _playerController;

        private Vector3 _firstPos, _endPos;

        private float _offSet;

        public BoxHorizontalMovementMouse(PlayerController playerController)
        {
            _playerController = playerController;
        }


        public void TickFixed(float Speed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _firstPos = Input.mousePosition;
            }

            else if (Input.GetMouseButton(0))
            {
                _endPos = Input.mousePosition;
                _offSet = (_endPos.x - _firstPos.x)/10;
            }

            if (Input.GetMouseButtonUp(0))
            {
                _firstPos = Vector3.zero;
                _endPos = Vector3.zero;
            }
            _playerController.transform.Translate(0, 0, _offSet * Time.deltaTime * Speed);

        }

      
    }

}
