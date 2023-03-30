using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sca : MonoBehaviour
{
    public float scaleMultiplier = 1f;

    void Start()
    {
        float screenHeight = Screen.height;
        float targetHeight = Camera.main.orthographicSize * 2f; // Get the height of the camera's orthographic view

        float ratio = targetHeight / screenHeight; // Calculate the ratio of the target height to the actual screen height

        transform.localScale = new Vector3(ratio, ratio, ratio) * scaleMultiplier; // Scale the object using the ratio and multiplier
    }


    void Update()
    {

    }
}
