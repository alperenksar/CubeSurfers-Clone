using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.Abstracts.Movement
{
    public interface IVerticalMovement 
    {
        void VerticalMovementAction(Vector3 direction, float MoveSpeed);
    }

}
