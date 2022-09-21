using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSurfers.UI
{
    public class ColorChange : MonoBehaviour
    {

        public void TickFixed(GameObject gameObject)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }

    }

}
