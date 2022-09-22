using CubeSurfers.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Movement
{
    public class BoxHorizontalMovementTouch : MonoBehaviour
    {
        PlayerController _playerController;

        private float _moveSpeed;

        private Touch touch;

        public Vector3 _firstTouchPos, _lastTouchPos;

        private bool _dragStarted, _isMoving;

        

        public BoxHorizontalMovementTouch(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = _playerController.VerticalMoveSpeed;
        }

        private void Update()
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    _dragStarted = true;
                    _isMoving = true;

                    _firstTouchPos = touch.position;
                    _lastTouchPos = touch.position;
                }
            }


            if (_dragStarted)
            {
                if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Ended)
                {
                    _firstTouchPos = touch.position;
                    _dragStarted = false;
                }

                
            }


        }

        public void FixedTick()
        {
            _playerController.transform.Translate(CalculateDirection() * _moveSpeed * Time.deltaTime);
        }

        Vector3 CalculateDirection()
        {
            Vector3 temp = (_firstTouchPos - _lastTouchPos).normalized;
            temp.z = temp.y;
            temp.y = 0;
            temp.x = 0;
            return temp;
        }

        

    }

}
