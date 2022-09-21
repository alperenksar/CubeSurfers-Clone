using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Movement;
using CubeSurfers.Managers;

namespace CubeSurfers.Controller
{
    public class PlayerController : MonoBehaviour
    {
        Animator animator;

        BoxVerticalMovement _boxVerticalMovement;

        [SerializeField]
        private float _verticalMoveSpeed;

        Rigidbody rb;

        public float VerticalMoveSpeed =>_verticalMoveSpeed;

        private void Awake()
        {
            rb=GetComponent<Rigidbody>();
            _boxVerticalMovement =new BoxVerticalMovement(this);    
            animator = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {
            if (!GameManager.Instance.IsGameActive) return;
                            
            _boxVerticalMovement.TickFixed();           
        }



       






    }

}
