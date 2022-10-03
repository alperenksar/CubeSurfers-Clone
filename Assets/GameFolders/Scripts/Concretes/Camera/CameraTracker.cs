using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.Cameras
{
    public class CameraTracker : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        private Vector3 _offSet;

        private Vector3 current;

        float x;


        private void Start()
        {
            _offSet = transform.position - _target.transform.position;
         
        }

        private void LateUpdate()
        {
            current = _target.transform.position + _offSet;
            transform.position = current;
           
        }

       
    }

}
