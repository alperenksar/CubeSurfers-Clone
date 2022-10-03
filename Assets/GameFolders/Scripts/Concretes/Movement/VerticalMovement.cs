using CubeSurfersClone.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfersClone.Abstracts.Movement;



namespace CubeSurfersClone.Movement
{
    public class VerticalMovement : IVerticalMovement
    {
        PlayerController _playerController;

        public VerticalMovement(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void VerticalMovementAction(Vector3 direction,float speed)
        {
            _playerController.transform.Translate(direction * speed * Time.deltaTime);
        }
    }

}
