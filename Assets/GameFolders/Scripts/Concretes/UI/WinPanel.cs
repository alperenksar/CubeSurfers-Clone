using CubeSurfersClone.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CubeSurfersClone.UI
{
    public class WinPanel : MonoBehaviour
    {
        [SerializeField] GameObject _winPanelObject;

        private void Awake()
        {
            if (_winPanelObject.activeSelf) _winPanelObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSuccedTrigger;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSuccedTrigger;

        }

        private void HandleOnMissionSuccedTrigger()
        {
            _winPanelObject.SetActive(true);
                
        }



    }

}
