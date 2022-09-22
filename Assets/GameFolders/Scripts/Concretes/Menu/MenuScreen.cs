using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CubeSurfers.Managers;

namespace CubeSurfers.Menu
{
    public class MenuScreen : MonoBehaviour
    {
        [SerializeField] private Vector3 _startPos;

        [SerializeField] private float _maxBoundaryX;
 
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            transform.Translate(-Vector3.right * 5f * Time.deltaTime);
            if (transform.position.x < _maxBoundaryX) 
            {
                transform.position=_startPos;
            }

        }

        public void StartGame()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitGame()
        {
            GameManager.Instance.Exit();
        }

    }

}
