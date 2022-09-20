using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Controller;

namespace CubeSurfers.Movement
{
    public class BoxVerticalMovement : MonoBehaviour
    {
        PlayerController _playerController;
       
        private float _moveSpeed;
        private float _moveBound;


        public BoxVerticalMovement(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = _playerController.VerticalMoveSpeed;
        }

        public void TickFixed()
        {
            _playerController.transform.Translate(-Vector3.right * _moveSpeed * Time.deltaTime);
        }



    }




}
