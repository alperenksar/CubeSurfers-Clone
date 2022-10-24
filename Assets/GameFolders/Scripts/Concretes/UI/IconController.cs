using CubeSurfersClone.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.UI
{
    public class IconController : MonoBehaviour
    {

        public bool IsGameRunning;
        PauseAndContinueButton PauseAndContinueButton;

        private void Awake()
        {
            PauseAndContinueButton =GameObject.Find("Canvas").GetComponentInChildren<PauseAndContinueButton>();
            IsGameRunning = true;
        }


        public void StopTheGame()
        {
            Time.timeScale = 0;
            IsGameRunning = false;
            PauseAndContinueButton.SetActiveContinueButton();
        }

        public void ContinueTheGame()
        {
            Time.timeScale = 1f;
            IsGameRunning = true;
            PauseAndContinueButton.SetActivePauseButton();
        }

        public void ReturnTheMenu()
        {
            GameManager.Instance.LoadMenuScene();
        }

        public void RestartGame()
        {
            GameManager.Instance.LoadLevelScene(0);
        }

        public void NextLevel()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }

}

