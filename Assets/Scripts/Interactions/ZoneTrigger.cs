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
    /*
    void OnTriggerEnter(Collider2D other)
    {
        _enterZone.Invoke(true, other.gameObject);
    }

    void OnTriggerExit(Collider2D other)
    {
        _enterZone.Invoke(false, other.gameObject);
    }
    */
}
