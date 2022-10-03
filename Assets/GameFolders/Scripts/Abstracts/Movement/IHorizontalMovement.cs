using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSurfersClone.Abstracts.Movement
{
    public interface IHorizontalMovement
    {
        void HorizontalMovementAction(Vector3 direction,float MoveSpeed);
    }

}