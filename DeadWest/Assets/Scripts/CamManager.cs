using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject facetrackingCam;

    private void Start()
    {
        Cursor.visible = false;

        if (PlayerPrefs.GetInt("CamToUse") == 0)
        {
            cam.SetActive(false);
            facetrackingCam.SetActive(true);
        }
        else
        {
            cam.SetActive(true);
            facetrackingCam.SetActive(false);
        }
    }
}
