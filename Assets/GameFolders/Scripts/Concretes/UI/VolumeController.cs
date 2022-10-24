using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace CubeSurfersClone.UI
{
    public class VolumeController : MonoBehaviour
    {
        public AudioMixer audioMixer;

       public void VolumeSliderSet(float volume)
        {
            audioMixer.SetFloat("Volume", volume);
        }
    }

}
