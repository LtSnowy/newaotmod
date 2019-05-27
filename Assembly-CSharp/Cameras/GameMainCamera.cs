using System;
using System.Runtime.InteropServices;
using UnityEngine;


class GameMainCamera : MonoBehaviour
{
    private float MultiDistanceOffset;

    public static float CameraDistance = 0.6f;

    private Transform Head;

    public GameObject MainObject;

    private float MultiHeight;
    
    private void Awake()
    {
        base.name = "MainCam";
        if (PlayerPrefs.HasKey("GameQuality"))
        {
            if (PlayerPrefs.GetFloat("GameQuality") >= 0.9f)
            {
                base.GetComponent<TiltShift>().enabled = true;
            }
            else
            {
                base.GetComponent<TiltShift>().enabled = false;
            }
        }
        else
        {
            base.GetComponent<TiltShift>().enabled = true;
        }
    }

    private void CameraMovement()
    {
        this.MultiDistanceOffset = (CameraDistance * (200f - base.camera.fieldOfView)) / 150f;
        base.transform.position = (this.Head == null) ? this.MainObject.transform.position : this.Head.transform.position;
        Transform transform = base.transform;
        transform.position += (Vector3)(Vector3.up * this.MultiHeight);
        Transform transform2 = base.transform;
        transform2.position -= ((Vector3.up * (0.6f - CameraDistance)) * 2f);
    }
}
