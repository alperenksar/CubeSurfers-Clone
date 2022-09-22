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

        Rigidbody rb;

        BoxHorizontalMovementMouse _boxHorizontalMovementMouse;

        BoxVerticalMovement _boxVerticalMovement;


        [SerializeField] private float _verticalMoveSpeed;
        [SerializeField] private float _horizontalMoveSpeed;

        [SerializeField] private float _horizontalBoundary;

        public float VerticalMoveSpeed => _verticalMoveSpeed;

        public float HorizontalMoveSpeed => _horizontalMoveSpeed;

        

        private void Awake()
        {
            rb=GetComponent<Rigidbody>();
            _boxVerticalMovement =new BoxVerticalMovement(this);
            _boxHorizontalMovementMouse =new BoxHorizontalMovementMouse(this);
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (transform.position.z >= _horizontalBoundary)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, _horizontalBoundary);
            }
            else if (transform.position.z <= -_horizontalBoundary)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -_horizontalBoundary);
            }
        }



        private void FixedUpdate()
        {
            if (!GameManager.Instance.IsGameActive) return;
                            
            _boxVerticalMovement.TickFixed();

            _boxHorizontalMovementMouse.TickFixed(_horizontalMoveSpeed);
        }

    }

}
