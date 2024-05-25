using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCameraLock : MonoBehaviour
{
    //get the sprite render to get the world height of the image and clamp it to the camera
    [SerializeField]Vector3 _startPos;
    [SerializeField]float padding = 29f;
    Camera _camera ;
    [SerializeField]Vector3 _cam;


    void Awake()
    {
        _camera =FindFirstObjectByType <Camera>();
        _startPos= GetComponent<RectTransform>().localPosition;
    }
    void Update()
    {
        /*
        if(transform.localPosition.y < padding)
        {
        }
        */
        _cam =_camera.gameObject.GetComponent<Transform>().localPosition;
        if(_camera.gameObject.GetComponent<Transform>().localPosition.x > padding)
        {
            Debug.Log("Should switch ");
            //transform.localPosition = _startPos;
        }
    }
}
