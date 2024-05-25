using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IdaGameJam.Core.Config
{
    ///<summary>
    /// Sets type HealthSO and when the game starts give this value to the character
    ///</summary>
    [CreateAssetMenu(fileName = "HealthConfigSO", menuName = "Configs/Health Configurable SO")]
    public class HealthConfigSO : ScriptableObject
    {
       [SerializeField]int _startingHealth;
       public int StartingHealth => _startingHealth;
    }
}