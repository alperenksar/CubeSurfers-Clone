using CubeSurfersClone.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfersClone.Animations
{
    public class CharacterAnimations : MonoBehaviour
    {

        Animator _animator;
        public CharacterAnimations(PlayerController entity)
        {
            _animator = entity.GetComponentInChildren<Animator>();
        }

        public void GameOverAnimations()
        {
            _animator.SetBool("IsGameOver", true);
        }
    }

}
