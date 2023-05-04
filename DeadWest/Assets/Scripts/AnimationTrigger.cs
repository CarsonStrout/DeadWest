using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField] private Animator[] animations;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        for (int i = 0; i < animations.Length; i++)
            animations[i].SetTrigger("Start");
    }
}
