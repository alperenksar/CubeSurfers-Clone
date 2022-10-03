using CubeSurfersClone.Abstracts.Movement;
using CubeSurfersClone.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : IHorizontalMovement
{

    PlayerController _playerController;

    float _maxBoundZ = 4.35f;
    float _minBoundZ = -4.35f;

    public HorizontalMovement(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void HorizontalMovementAction(Vector3 direction,float speed)
    {
        _playerController.transform.Translate(direction * speed * Time.deltaTime);

        if (_playerController.transform.position.z > _maxBoundZ)
        {
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y, _maxBoundZ);
        }

        if (_playerController.transform.position.z < _minBoundZ)
        {
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y, _minBoundZ);
        }
    }

}
