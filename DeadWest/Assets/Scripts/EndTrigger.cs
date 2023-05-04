using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private LevelLoader levelLoader;

    private void OnTriggerEnter(Collider other)
    {
        levelLoader.LoadNextLevel();
    }
}
