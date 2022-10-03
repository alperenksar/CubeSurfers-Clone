using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.Controller
{
    public class IncreaseStackController 
    {

        CubeController _cubeController;

        public IncreaseStackController(CubeController cubeController)
        {
            _cubeController = cubeController;
        }

        public void IncreaseCubeStack(GameObject lastCube,GameObject cube)
        {
                Debug.Log("Processing Increase Cube Stack");
                _cubeController.transform.position = new Vector3(_cubeController.transform.position.x, _cubeController.transform.position.y + 1, _cubeController.transform.position.z);
                cube.gameObject.transform.SetParent(_cubeController.transform);
                cube.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                cube.transform.position = new Vector3(_cubeController.transform.position.x, lastCube.transform.position.y - 1f, _cubeController. transform.position.z);
        }

    }

}
