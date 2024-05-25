using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdaGameJam.Core.Config
{
    /// <summary>
    /// An asset, to Set the default attack parameter
    /// </summary>
    [CreateAssetMenu(fileName = "AttackConfigSO", menuName = "Configs/Attack Configurable SO")]
    public class AttackConfigSO : ScriptableObject
    {
        [SerializeField]int _damageValue;
        [SerializeField]float timeBetweenAttacks;

        public int DamageValue => _damageValue;
        public float TimeBetweenAttacks => timeBetweenAttacks;
    }
}
