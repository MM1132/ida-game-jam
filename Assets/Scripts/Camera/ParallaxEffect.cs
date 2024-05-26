using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform[] backgrounds;
    [SerializeField]float[] parralaxscale;
    public float smoothing;
    [SerializeField]Transform _cam;
    [SerializeField]Vector3 previousCamPos;

    void Awake()
    {
        _cam = Camera.main.transform;
    }

    void Start()
    {
        previousCamPos = _cam.position;
        parralaxscale = new float[backgrounds.Length];
        for(int i = 0; i < backgrounds.Length;i++)
        {
            parralaxscale[i] = backgrounds[i].position.z *-1;
        }    
    }

    void Update()
    {
        for(int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (previousCamPos.x-_cam.position.x)*parralaxscale[i];
            float backgroundTargetPosX = backgrounds[i].position.x+parallax;
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX,backgrounds[i].position.y,backgrounds[i].position.z);
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position,backgroundTargetPos,smoothing * Time.deltaTime);
        }
        previousCamPos = _cam.position;
    }
}
