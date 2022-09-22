using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Controller
{
    public class TrailController : MonoBehaviour
    {
       PlayerController playerController;
       TrailRenderer trailRenderer;
        BoxController boxController;

        private void Awake()
        {
 
            playerController = GameObject.Find("Player").GetComponent<PlayerController>();
            trailRenderer=GetComponent<TrailRenderer>();
        }

        private void Start()
        {
            trailRenderer.material.color = Color.green;
        }

        private void Update()
        {
            transform.position = new Vector3(playerController.transform.position.x, transform.position.y, playerController.transform.position.z);
        }

        private void FixedUpdate()
        {            
            ChangeTrailColor();
        }

        void ChangeTrailColor()
        {
            if (playerController.transform.position.y >= 1)
            {
                trailRenderer.material.color = Color.green;
            }
            else
            {
                trailRenderer.material.color = Color.yellow;
            }
        }
    }

}
