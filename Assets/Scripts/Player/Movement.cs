using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IdaGameJam.Core.Input;
using System;

public class Movement : MonoBehaviour
{
    [SerializeField]InputHandler _controller;
    [SerializeField]RectTransform _rect => GetComponent<RectTransform>();
    [SerializeField]Rigidbody2D _rigidbody => GetComponent<Rigidbody2D>();
    [SerializeField]float speed,jumpforce;
    [SerializeField]Vector3 jump;
    SpriteRenderer spr=> GetComponent<SpriteRenderer>();
    public Vector2 _moveValue;
    public bool isAirbone;
    bool invertValue,lastValue;

    void OnEnable()
    {
        _controller.MoveEvent += MoveInput;
        _controller.JumpEvent += Jump;
    }

    void Update()
    {
        //lock the rotation
        //_rect.transform.localRotation = Quaternion.Euler(new Vector3());
        //increase the speed
        var i = _moveValue.normalized * speed * Time.unscaledDeltaTime;
        _rect.transform.localPosition += new Vector3(i.x,i.y,0);
    }

    void MoveInput(Vector2 x)
    {
        _moveValue = new Vector2(x.x,0);

        //control the sprite
        invertValue = (x.x == 1)? false: true;
        var temp = invertValue;
        invertValue = lastValue;
        lastValue = temp; 
        spr.flipX = invertValue;
    }

    void OnDisable()
    {
        _controller.MoveEvent -= MoveInput;
        _controller.JumpEvent -= Jump;
    }

    void Jump()
    {
        if(isAirbone)return;
        _rigidbody.AddForce(jump*jumpforce,ForceMode2D.Impulse);
    }
    
    /// <summary>
    /// Checks if the player is airbone and adjust accordingly
    /// </summary>
    /// <param name="hit"></param>
    /// <param name="obj"></param>
    public void OnColliderEnter(bool hit, GameObject obj)
    {
        if(hit)
        {
            isAirbone = false;
        }else
        {
           isAirbone = true;
        }
    }
}
