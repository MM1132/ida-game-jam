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
    public Vector2 _moveValue;
    public bool isMoving;

    void OnEnable()
    {
        _controller.MoveEvent += MoveInput;
        _controller.JumpEvent += Jump;
    }

    void Update()
    {
        var i = _moveValue.normalized * speed * Time.unscaledDeltaTime;
        _rect.transform.localPosition += new Vector3(i.x,i.y,0);
    }

    void MoveInput(Vector2 x)
    {
        _moveValue = new Vector2(x.x,0);
    }

    void OnDisable()
    {
        _controller.MoveEvent -= MoveInput;
    }

    void Jump()
    {
        _rigidbody.AddForce(jump*jumpforce,ForceMode2D.Impulse);
        isMoving = !isMoving;
    }
}
