using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdaGameJam.Core
{
    /// <summary>
    /// Responsbile for handling the health functionality 
    /// </summary>
    public class Incapacitate : MonoBehaviour
    {
        [Header("Health")]
        [SerializeField]Config.HealthConfigSO _healthConfigSO;
        [SerializeField]HealthSO _currenthealthSO;
        public bool canTakeDamage;

        void Awake()
        {
            if(_currenthealthSO == null)
            {
                _currenthealthSO = ScriptableObject.CreateInstance<HealthSO>();
            }
            _currenthealthSO.SetStartingHealth(_healthConfigSO.StartingHealth);
            _currenthealthSO.SetCurrentHealth(_healthConfigSO.StartingHealth);
    
        }

        public void TakeDamage(int damage)
        {
            _currenthealthSO.RecieveDamage(damage);
        }
    }
}
