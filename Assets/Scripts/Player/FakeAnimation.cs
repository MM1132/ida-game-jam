using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeAnimation : MonoBehaviour
{
    Movement _movement => GetComponent<Movement>();
    float count;
    [SerializeField]int fps;
    [SerializeField]Sprite _spriteA,_spriteB;
    SpriteRenderer _spr => GetComponent<SpriteRenderer>();

    void Update()
    {
        if (_movement.isMoving && !_movement.isAirbone)
        {
            count += Time.deltaTime *2f;

            if(count >1)
            {
                count = 0;
            }

            if(count == 0)
            {
                fps++;
            }
            _spr.sprite = (fps % 2 ==0) ? _spriteA : _spriteB;
        }
    }
}
