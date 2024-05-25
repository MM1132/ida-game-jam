using System.Collections;
using System.Collections.Generic;
using IdaGameJam.Core.Config;
using UnityEngine;

namespace IdaGameJam.Core
{
    public class Attack : MonoBehaviour
    {
        [SerializeField]AttackConfigSO _attackConfigSO;
        public AttackConfigSO AttackConfigSO => _attackConfigSO;
        // Start is called before the first frame update
        void Awake()
        {
            gameObject.SetActive(false);
        }

        void OnColliderEnter(Collider2D other)
        {
            //avoid friendly fire
            if(other.CompareTag(gameObject.tag))return;
            if(other.TryGetComponent(out Incapacitate _incapacitate))
            {
                if(!_incapacitate.canTakeDamage)return;
                _incapacitate.TakeDamage(_attackConfigSO.DamageValue);
            }
        }
    }
}