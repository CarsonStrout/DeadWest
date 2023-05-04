using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    [SerializeField] private AnimationTrigger animationTrigger;
    [SerializeField] private AudioSource gunShot;
    private float timer = 0;

    private void Update()
    {
        if (animationTrigger.activeStart)
        {
            timer += Time.deltaTime;
            if (timer >= 3.15f)
            {
                gunShot.Play();
                animationTrigger.activeStart = false;
            }
        }
    }
}
