using CubeSurfers.Abstracts.Utilities;
using CubeSurfers.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfers.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        [SerializeField] AudioSource[] audioSources;

        private void Awake()
        {
            SingletonThisGameObject(this);
            audioSources = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!audioSources[index].isPlaying)
            {
                audioSources[index].Play();
            }
        }

        public void StopSound(int index)
        {
            if (audioSources[index].isPlaying)
            {
                audioSources[index].Stop();

            }
        }
    }

}
