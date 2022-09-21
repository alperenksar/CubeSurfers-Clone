using CubeSurfers.Controller;
using CubeSurfers.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Manager
{
    public class BoxManager : MonoBehaviour
    {
        PlayerController _playerController;

        private void Awake()
        {
            _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        }


        public void IncreaseNewBlock(GameObject _willAddgameObject,GameObject _lastCube , List<GameObject> cubes )
        {
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y + 1f, _playerController.transform.position.z);
            _willAddgameObject.gameObject.transform.SetParent(_playerController.transform);
            _willAddgameObject.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            _willAddgameObject.transform.position = new Vector3(_playerController.transform.position.x, _lastCube.transform.position.y - 1f, _playerController.transform.position.z);
            cubes.Add(_willAddgameObject.gameObject);
        }

        public void DecreaseBlock(GameObject _willRemovegameObject, GameObject _lastCube, List<GameObject> cubes)
        {
            _lastCube.transform.parent = null;

            cubes.Remove(_lastCube);
            Destroy(_lastCube);
            Destroy(_willRemovegameObject);
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y - 1f, _playerController.transform.position.z);
            cubes.Remove(_lastCube);
        }

    }
}

