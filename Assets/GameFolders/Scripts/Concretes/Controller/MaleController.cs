using CubeSurfers.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Controller
{
    public class MaleController : MonoBehaviour
    {
        Animator animator;

        [SerializeField] private float _speed = 2f; 
        PlayerController playerController;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        }

        private void FixedUpdate()
        {
            if (!GameManager.Instance.IsGameActive)
            {
                animator.SetBool("isGameActive", false);

                if (transform.position.y >= -0.5f)
                {
                    transform.Translate(Vector3.down * _speed * Time.deltaTime);
                }
                

            }
        }

        private void LateUpdate()
        {
            if (!GameManager.Instance.IsGameActive) return; 

            transform.position = new Vector3(playerController.transform.position.x,playerController.transform.position.y+0.5f, playerController.transform.position.z);
        }


    }

}
