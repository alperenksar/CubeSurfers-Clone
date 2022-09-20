using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Movement;

namespace CubeSurfers.Controller
{
    public class PlayerController : MonoBehaviour
    {
        BoxController _boxController;
        BoxVerticalMovement _boxVerticalMovement;

        [SerializeField]
        private float _verticalMoveSpeed;

        Rigidbody rb;

        public Rigidbody _rb => rb;
        

        public float VerticalMoveSpeed =>_verticalMoveSpeed;

        private void Awake()
        {
            rb=GetComponent<Rigidbody>();
            _boxVerticalMovement =new BoxVerticalMovement(this);            
        }

        private void FixedUpdate()
        {
            _boxVerticalMovement.TickFixed();

        }






    }

}
