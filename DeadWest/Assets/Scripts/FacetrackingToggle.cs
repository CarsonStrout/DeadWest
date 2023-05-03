using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacetrackingToggle : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetInt("CamToUse", 0);
    }

    public void UseFacetracking()
    {
        if (PlayerPrefs.GetInt("CamToUse") == 0)
            PlayerPrefs.SetInt("CamToUse", 1);
        else
            PlayerPrefs.SetInt("CamToUse", 0);
    }
}
