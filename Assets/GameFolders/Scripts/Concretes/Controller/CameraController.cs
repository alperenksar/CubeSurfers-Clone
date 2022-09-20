using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSurfers.Controller
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _target;
        private Vector3 _offset;

        private void Awake()
        {
            _offset = transform.position - _target.transform.position;
        }


        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, _target.transform.position + _offset, 1f);
        }
    }

}
