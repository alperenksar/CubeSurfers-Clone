using CubeSurfersClone.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.UI
{
    public class PauseAndContinueButton : MonoBehaviour
    {
        [SerializeField] private GameObject _pauseButton;
        [SerializeField] private GameObject _continueButton;

        IconController IconController;

        private void Awake()
        {
            IconController = GetComponent<IconController>();
            if (_continueButton.activeSelf) _continueButton.SetActive(false);           
        }

        public void SetActiveContinueButton()
        {
            _continueButton.SetActive(true);
            _pauseButton.SetActive(false);
        }

        public void SetActivePauseButton()
        {
            _continueButton.SetActive(false);
            _pauseButton.SetActive(true);
        }
    }

}
