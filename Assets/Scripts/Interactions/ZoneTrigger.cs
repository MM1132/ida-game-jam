using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using IdaGameJam.Core.SO.Events;

[System.Serializable]
public class BoolEvent : UnityEvent<bool,GameObject>{}
 /// <summary>
    /// A generic class for a "zone", that is a trigger collider that can detect if an object entered or exited it.
    /// Implements <code>OnTriggerEnter</code> and <code>OnTriggerExit</code> so it needs to be on the same object that holds the Collider.
    /// </summary>
public class ZoneTrigger : MonoBehaviour
{
    [SerializeField]BoolEvent _enterZone = default;
    [SerializeField]LayerMask _layers = default;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if((1 << other.gameObject.layer & _layers) != 0)
        {
            _enterZone.Invoke(true, other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if((1 << other.gameObject.layer & _layers) != 0)
        {
            _enterZone.Invoke(false, other.gameObject);
        }
    }
}
