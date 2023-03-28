using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
