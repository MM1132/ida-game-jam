using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace IdaGameJam.Core.SO.Events
{
    [CreateAssetMenu(menuName = "Events/Bool Event Channel")]
    public class BoolEventSO : DescriptionBaseSO
    {
        public UnityAction<bool> OnEventRaised;
        public void RaiseEvent(bool value)
        {
            OnEventRaised?.Invoke(value);
        }
    }
}