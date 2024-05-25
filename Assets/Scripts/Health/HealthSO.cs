using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdaGameJam.Core
{
    [CreateAssetMenu(fileName ="Health", menuName ="Configs/Default Health SO")]
    public class HealthSO : ScriptableObject
    {
        [Tooltip ("Health given at default")]
        [SerializeField]
        int _startingHealth;
        [SerializeField]
        int _currentHealth;
        public int StartingHealth => _startingHealth;
        public int CurrentHealth =>_currentHealth;

        public void SetStartingHealth(int newValue)
        {
            _startingHealth = newValue;
        }

        public void SetCurrentHealth(int newValue)
        {
            _currentHealth = newValue;
        }

        public void RecieveDamage(int damageValue)
        {
            _currentHealth -= damageValue;
        }

        public void RestoreHealth(int healingValue)
        {
            _currentHealth += healingValue;
        }

        public bool LowHealth()
        {
            //if the health is less than 10 percent return true 
            return _currentHealth <= 10f/100f * _startingHealth;
        }

        public bool MaxHealth()
        {
            return _currentHealth == _startingHealth;
        }
    }   
}