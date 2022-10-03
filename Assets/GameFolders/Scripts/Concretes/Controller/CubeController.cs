using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using CubeSurfersClone.Manager;
using CubeSurfersClone.UI;
using TMPro;

namespace CubeSurfersClone.Controller
{
    public class CubeController : MonoBehaviour
    {
        CubeCounter _CubeCounter;

        IncreaseStackController _IncreaseStackController;

        DecreaseStackController _DecreaseStackController;

        [SerializeField] private List<GameObject> cubes=new List<GameObject>();

        [SerializeField] private TextMeshProUGUI cubeCounter;

        private GameObject _lastCube;


        private void Awake()
        {
            _IncreaseStackController = new IncreaseStackController(this);
            _DecreaseStackController = new DecreaseStackController(this);
            UpdateLastBlockObject();
            cubeCounter =GameObject.Find("CubePanel").GetComponentInChildren<TextMeshProUGUI>();
            _CubeCounter = new CubeCounter(this);
        }

        private void FixedUpdate()
        {
            float CountCube = cubes.Count;

            _CubeCounter.FixedTick(CountCube, cubeCounter);

            if (CountCube == 0)
            {
                GameManager.Instance.GameOver();
            }
        }

        private void OnTriggerEnter(Collider _cube)
        {
            if (_cube.gameObject.CompareTag("IncreaseCubeStack"))
            {
                _IncreaseStackController.IncreaseCubeStack(_lastCube, _cube.gameObject);
                cubes.Add(_cube.gameObject);
                UpdateLastBlockObject();
            }

            else if (_cube.gameObject.CompareTag("DecreaseCubeStack"))
            {
                _DecreaseStackController.DecreaseCubeStack(_lastCube, _cube.gameObject);
                cubes.Remove(_lastCube.gameObject);
                UpdateLastBlockObject();
            }

            else if (_cube.gameObject.CompareTag("FinishLine"))
            {
                if (cubes.Count > 0) 
                {
                    Debug.Log("Mission Succed");
                    GameManager.Instance.MissionSucced();
                }
                else
                {
                    Debug.Log("Try Again");
                    GameManager.Instance.GameOver();

                }

            }

        }



        private void UpdateLastBlockObject()
        {
            _lastCube = cubes[cubes.Count - 1];
        }
    }

}
