using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;
using CubeSurfersClone.Abstracts.Input;
using CubeSurfersClone.Abstracts.Movement;
using CubeSurfersClone.Manager;
using CubeSurfersClone.Movement;
using CubeSurfersClone.Animations;
using CubeSurfersClone.UI;

namespace CubeSurfersClone.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Header("VerticalMovement")]
        [SerializeField] private float verticalSpeed;
        [SerializeField] private Vector3 verticalDirection;

        [Header("HorizontalMovement")]
        [SerializeField] private float horizontalSpeed;
        [SerializeField] private Vector3 horizontalDirection;



        public float VerticalSpeed => verticalSpeed;

        public float HorizontalSpeed => horizontalSpeed;


        IVerticalMovement _verticalMovement;

        IHorizontalMovement _horizontalMovement;

        IInputReader _input;

        CharacterAnimations _characterAnimations;

        bool IsGameOver;



        private void Awake()
        {
            IsGameOver = false;
            _input = GetComponent<IInputReader>();
            _verticalMovement = new VerticalMovement(this);
            _horizontalMovement = new HorizontalMovement(this);
            _characterAnimations = new CharacterAnimations(this);
        }

        private void Update()
        {
            horizontalDirection = _input.Direction;
        }


        private void FixedUpdate()
        {
            _verticalMovement.VerticalMovementAction(verticalDirection, VerticalSpeed);
            _horizontalMovement.HorizontalMovementAction(horizontalDirection, HorizontalSpeed);
        }

        private void LateUpdate()
        {
            if (IsGameOver == false) return;

            _characterAnimations.GameOverAnimations();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSuccedTrigger;
            GameManager.Instance.OnGameOver += HandleOnGameOverTrigger;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSuccedTrigger;
            GameManager.Instance.OnGameOver -= HandleOnGameOverTrigger;

        }

        private void HandleOnMissionSuccedTrigger()
        {
            verticalSpeed = 0f;
            horizontalSpeed = 0f;
            Debug.Log("HandleOnMissionSuccedTrigger process");
        }

        private void HandleOnGameOverTrigger()
        {
            IsGameOver = true;            
            Debug.Log("Game Over!!!");
        }

    }

}
