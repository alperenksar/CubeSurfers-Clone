using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.Controller
{
    public class DecreaseStackController 
    {
        CubeController _cubeController;

        public DecreaseStackController(CubeController cubeController)
        {
            _cubeController = cubeController;
        }

        public void DecreaseCubeStack(GameObject lastCube, GameObject cube)
        {
            Debug.Log("Processing Decrease Cube Stack");
            //_cubeController.transform.position = new Vector3(_cubeController.transform.position.x, _cubeController.transform.position.y - 1, _cubeController.transform.position.z);
            cube.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            lastCube.transform.parent = null;


        }
    }

}
