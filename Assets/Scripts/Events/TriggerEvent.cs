using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IdaGameJam.Core.SO;
using UnityEngine.Events;

namespace IdaGameJam.Core.SO.Events
{
    [CreateAssetMenu(menuName = "Events/Zone Trigger Channel")]
    public class TriggerEvent : DescriptionBaseSO
    {
        public UnityAction<bool,GameObject> OnEventRaised;
        public void RaiseEvent(bool value, GameObject target)
        {
            OnEventRaised?.Invoke(value, target);
        }
    }

}
