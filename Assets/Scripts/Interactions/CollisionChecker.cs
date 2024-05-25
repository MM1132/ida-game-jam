using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    [SerializeField]BoxCollider2D _boxCollider;

    void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter()
    {
        
    }
}
