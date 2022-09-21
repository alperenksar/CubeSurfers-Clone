using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfers.Managers;

namespace CubeSurfers.Controller
{
    public class ObstacleController : MonoBehaviour
    {
        BoxCollider boxCollider;

        private void Awake()
        {
            boxCollider =GetComponent<BoxCollider>();
        }
        private void Update()
        {
          
            if (GameManager.Instance.IsGameActive) return;

            AddRb();


        }

        void AddRb()
        {
            boxCollider.isTrigger = false;

            boxCollider.size=new Vector3(1f,1f,1f);

            gameObject.AddComponent<Rigidbody>();

          
        }

    }

}
