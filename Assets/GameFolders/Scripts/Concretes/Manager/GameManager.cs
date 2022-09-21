using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CubeSurfers.Abstracts.Utilities;

namespace CubeSurfers.Managers
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

            //if (OnGameOver != null) GameOver();
            
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
            SoundManager.Instance.StopSound(0);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelindex);
            SoundManager.Instance.PlaySound(1);

        }

        public void LoadMenuScene()
        {
            SoundManager.Instance.StopSound(1);
            StartCoroutine("LoadMenuSceneAsync");
            SoundManager.Instance.PlaySound(0);
        }

        IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }


        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }


}
