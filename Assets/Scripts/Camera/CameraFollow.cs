using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]RectTransform _playerTranform;
    [SerializeField]float cameraSmothing;
    [SerializeField]Vector3 offsetPos;
    Movement x;

    void Start()
    {
        x = _playerTranform.gameObject.GetComponent<Movement>();
    }

    void Update()
    {
        Vector3 tragetPos = _playerTranform.position + offsetPos;
        transform.position = Vector3.Lerp(transform.position,tragetPos,cameraSmothing *Time.deltaTime);
    }

    //should clamp the camera to the background 
}
