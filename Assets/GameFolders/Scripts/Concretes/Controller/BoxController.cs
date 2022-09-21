using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Manager;
using CubeSurfers.UI;
using CubeSurfers.Managers;

namespace CubeSurfers.Controller
{
    public class BoxController : MonoBehaviour
    {
        BoxManager _boxManager;
        ColorChange _colorChange;

        [SerializeField] private GameObject _cubePrefab;
        [SerializeField] private List<GameObject> _cubes = new List<GameObject>();

        private GameObject _lastCube;

      
        private void Awake()
        {
            _colorChange = new ColorChange();
            _boxManager = GameObject.Find("BoxManager").GetComponent<BoxManager>();
            UpdateLastBlockObject();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("IncreaseCubeStack"))
            {
                _boxManager.IncreaseNewBlock(other.gameObject,_lastCube,_cubes);                
                UpdateLastBlockObject();
            }

            else if (other.CompareTag("DecreaseCubeStack"))
            {
                _boxManager.DecreaseBlock(other.gameObject, _lastCube, _cubes);                
                UpdateLastBlockObject();
            }
        }

        private void UpdateLastBlockObject()
        {
            _lastCube = _cubes[_cubes.Count - 1];
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Plane")) 
            {
                _colorChange.TickFixed(collision.gameObject);
            }
        }

       





        //private void DecreaseBlock(GameObject _gameObject)
        //{
        //    _lastCube.transform.parent = null;
        //    _cubes.Remove(_lastCube);
        //    Destroy(_lastCube);
        //    Destroy(_gameObject);
        //    _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y - 1f, _playerController.transform.position.z);            
        //    _cubes.Remove(_lastCube);
        //    UpdateLastBlockObject();
        //}

        //private void IncreaseNewBlock(GameObject _gameObject)
        //{
        //    _playerController._rb.AddForce(Vector3.up*1f*Time.deltaTime);
        //    _playerController.transform.position = new Vector3(_playerController.transform.position.x, _playerController.transform.position.y + 1f, _playerController.transform.position.z);
        //    _gameObject.gameObject.transform.SetParent(transform);
        //    _gameObject.gameObject.GetComponent<BoxCollider>().isTrigger = false;
        //    _gameObject.transform.position = new Vector3(_playerController.transform.position.x, _lastCube.transform.position.y - 1f, _playerController.transform.position.z);
        //    _cubes.Add(_gameObject.gameObject);
        //    UpdateLastBlockObject();
        //}


    }

}

