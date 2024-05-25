using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IdaGameJam.Core.GamePlay;

namespace IdaGameJam.Core
{
    public class Enemy : MonoBehaviour
    {
        [Header("Enemy Type")]
        [SerializeField]EnemySO _enemySO;
        [SerializeField]Incapacitate _incapacitate;

        public void CauseChao(bool hit, GameObject obj)
        {
            if (hit && obj.TryGetComponent(out Incapacitate d))
            {
                Debug.Log($"Take damage {d.gameObject.name}");
                _incapacitate = d;
                _incapacitate.TakeDamage(9);
                
                obj.TryGetComponent(out Movement x );
                if(x.isAirbone== true)
                {
                    x.isAirbone = false;
                }
            }
            _incapacitate = null;
        }
    }
}