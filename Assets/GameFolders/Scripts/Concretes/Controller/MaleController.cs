using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CubeSurfers.Controller
{
    public class MaleController : MonoBehaviour
    {
        [SerializeField] private float _speed = 0.2f; 
        PlayerController playerController;
        Rigidbody rb;

        private void Awake()
        {
            playerController = GameObject.Find("Player").GetComponent<PlayerController>();
            rb = GetComponent<Rigidbody>();

        }

        private void FixedUpdate()
        {
            if (!playerController._isGameActive)
            {
                if (transform.position.y >= -0.5f)
                {
                    transform.Translate(Vector3.down * _speed * Time.deltaTime);
                }
                

            }
        }

        private void LateUpdate()
        {
            if (!playerController._isGameActive) return; 

            transform.position = new Vector3(playerController.transform.position.x,playerController.transform.position.y+0.5f, playerController.transform.position.z);
        }


    }

}
