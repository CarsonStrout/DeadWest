using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField] private Animator[] animations;
    [HideInInspector] public bool activeStart = false;

    private void OnTriggerEnter(Collider other)
    {
        activeStart = true;
        for (int i = 0; i < animations.Length; i++)
            animations[i].SetTrigger("Start");
    }
}
