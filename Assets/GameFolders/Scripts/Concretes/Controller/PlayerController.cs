using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Movement;
using CubeSurfers.Managers;

namespace CubeSurfers.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] bool IsGameActive = true;

        BoxVerticalMovement _boxVerticalMovement;

        [SerializeField]
        private float _verticalMoveSpeed;

        Rigidbody rb;

        public Rigidbody _rb => rb;

        public bool _isGameActive;
        

        public float VerticalMoveSpeed =>_verticalMoveSpeed;

        private void Awake()
        {
            rb=GetComponent<Rigidbody>();
            _boxVerticalMovement =new BoxVerticalMovement(this);            
        }

        private void FixedUpdate()
        {
            if (!IsGameActive) return; 
            _boxVerticalMovement.TickFixed();

        }

       






    }

}
