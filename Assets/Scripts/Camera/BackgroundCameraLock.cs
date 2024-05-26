using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundCameraLock : MonoBehaviour
{
    //get the sprite render to get the world height of the image and clamp it to the camera
    [SerializeField]float offset;
    float spriteWidth,_camOthSize,visiableEdgeRight,visiableEdgeLeft;
    Camera _camera ;
    SpriteRenderer sptder;
    Vector3 _cam;
    [SerializeField]bool InvertScale;
    public bool HasALeftBG,HasARightBG;
    [SerializeField]float counter;


    void Awake()
    {
        _camera =FindFirstObjectByType <Camera>();
        sptder = GetComponent<SpriteRenderer>();
        spriteWidth = sptder.sprite.bounds.size.x;
    }
    void Start()
    {
    }

    void Update()
    {
        _camOthSize =_camera.orthographicSize * Screen.width/Screen.height;
        visiableEdgeRight = (transform.localPosition.x + spriteWidth / 2) - _camOthSize;
        visiableEdgeLeft = (transform.localPosition.x - spriteWidth / 2) + _camOthSize;
        _cam =_camera.gameObject.GetComponent<Transform>().localPosition;
        if(_cam.x >= visiableEdgeRight- offset&& !HasARightBG )
        {
            MakeExtraBackground(1);
            HasARightBG = true;
        }else if (_cam.x<= visiableEdgeLeft + offset && !HasALeftBG)
        {
            MakeExtraBackground(-1);
            HasALeftBG = true;
        }

        /*
        //check if this current gameobject is still visible
        if(!sptder.isVisible)
        {
            Debug.Log($"Name : {transform.gameObject.name}");
        }
        */
    }

    void MakeExtraBackground(int rightOrLeft)
    {
        Vector3 newPosition = new Vector3(transform.localPosition.x+spriteWidth*rightOrLeft,transform.localPosition.y,transform.localPosition.z);
        RectTransform newBg = Instantiate(transform,newPosition,transform.localRotation) as RectTransform;

        if(InvertScale)
        {
            newBg.localScale = new Vector3(newBg.localScale.x *-1,newBg.localScale.y,newBg.localScale.z);  
        }
        newBg.SetParent(transform.parent);

        if(rightOrLeft > 0)
        {
            newBg.GetComponent<BackgroundCameraLock>().HasALeftBG = true;
        }else
        {
            newBg.GetComponent<BackgroundCameraLock>().HasARightBG = true;
        }
        //CrowdControl();
    }
    void CrowdControl()
    {
        //crowd control
        var x = FindObjectsByType(typeof(BackgroundCameraLock),FindObjectsSortMode.None);
        
        for(int i = 0;i < x.Length; i++)
        {
            SpriteRenderer spt = x[i].GetComponent<SpriteRenderer>();
            bool left = x[i].GetComponent<BackgroundCameraLock>().HasALeftBG;
            bool right = x[i].GetComponent<BackgroundCameraLock>().HasARightBG;
            if(!spt.isVisible && left && right)
            {
                Debug.Log(x[i].name);
            }
        }
    }

    void OnDestory()
    {
        Debug.Log("I was killed off");
    }
}
