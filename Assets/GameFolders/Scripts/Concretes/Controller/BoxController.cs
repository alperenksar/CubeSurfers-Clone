using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Controller
{
    public class BoxController : MonoBehaviour
    {
        PlayerController _playerController;
        [SerializeField] private GameObject _cubePrefab;
        [SerializeField] private List<GameObject> _cubes = new List<GameObject>();

        private GameObject _lastCube;

      
        private void Awake()
        {
            _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
            UpdateLastBlockObject();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("IncreaseCubeStack"))
            {
                IncreaseNewBlock(other.gameObject);
            }

            else if (other.CompareTag("DecreaseCubeStack"))
            {
                DecreaseBlock(other.gameObject);
            }
        }

        private void UpdateLastBlockObject()
        {
            _lastCube = _cubes[_cubes.Count - 1];
        }

        private void DecreaseBlock(GameObject _gameObject)
        {
            _lastCube.transform.parent = null;
            _cubes.Remove(_lastCube);
            Destroy(_lastCube);
            Destroy(_gameObject);
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y - 1f, _playerController.transform.position.z);            
            _cubes.Remove(_lastCube);
            UpdateLastBlockObject();
        }

        private void IncreaseNewBlock(GameObject _gameObject)
        {
            _playerController._rb.AddForce(Vector3.up*1f*Time.deltaTime);
            _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y + 1f, _playerController.transform.position.z);
            _gameObject.gameObject.transform.SetParent(transform);
            _gameObject.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            _gameObject.transform.position = new Vector3(_playerController.transform.position.x, _lastCube.transform.position.y - 1f, _playerController.transform.position.z);
            _cubes.Add(_gameObject.gameObject);
            UpdateLastBlockObject();
        }


    }

}

