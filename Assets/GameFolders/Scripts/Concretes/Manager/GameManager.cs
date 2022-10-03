using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeSurfersClone.Abstracts.Utilities;
using UnityEngine.SceneManagement;


namespace CubeSurfersClone.Manager
{
    public class GameManager : SingletonThisObject<GameManager>
    {



        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }
        public void LoadLevelScene(int levelindex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelindex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelindex)
        {
            SoundManager.Instance.StopSound(0); //Stop Menu Sound
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelindex);
            SoundManager.Instance.PlaySound(1);//Play Game Sound

        }

        public void LoadMenuScene()
        {
            SoundManager.Instance.StopSound(1);//Stop Game Sound
            StartCoroutine("LoadMenuSceneAsync");
            SoundManager.Instance.PlaySound(0); //Play Menu Sound
        }

        IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("MenuScene");
        }


        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }


}
