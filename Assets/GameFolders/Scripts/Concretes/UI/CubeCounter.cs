using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using CubeSurfersClone.Controller;

namespace CubeSurfersClone.UI
{
    public class CubeCounter 
    {
        CubeController _cubeController;

        public CubeCounter(CubeController cubeController)
        {
            _cubeController = cubeController;
        }   

        public void FixedTick(float count,TextMeshProUGUI _cubeCounter)
        {
                _cubeCounter.text ="Cube : "+ count.ToString();
        }
    }

}
