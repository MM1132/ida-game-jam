using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCameraLock : MonoBehaviour
{
    //get the sprite render to get the world height of the image and clamp it to the camera
    [SerializeField]GameObject background;
    [SerializeField]SpriteRenderer spt;
    [SerializeField]Vector2 imagesize;

    void Awake()
    {
        spt= background.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        imagesize = spt.size;
    }
}
