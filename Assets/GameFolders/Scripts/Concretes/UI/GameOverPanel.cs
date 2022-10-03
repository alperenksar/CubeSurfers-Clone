using CubeSurfersClone.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverObject;

        private void Awake()
        {
            if (_gameOverObject.activeSelf) _gameOverObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOverTrigger;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOverTrigger; 
        }

        private void HandleOnGameOverTrigger()
        {
            _gameOverObject.SetActive(true);
        }


    }

}
