using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdaGameJam.Core.GamePlay
{
    ///<summary>
    /// This gives the idenity and score value to the Enemy 
    ///</summary>
    [CreateAssetMenu(fileName = "Enemy", menuName = "Enemy SO")]
    public class EnemySO : ScriptableObject
    {
         [Header("Enemy Type")]
        [SerializeField] EnemyType _enemyType;
        public EnemyType EnemyType => _enemyType;

        [Header("Score Value")]
        [SerializeField]int _scoreValue;
        public int ScoreValue =>_scoreValue;

        [Header("Enemy Prefab")]
        [SerializeField]GameObject _perfab;
        public GameObject Prefab => _perfab;
    }

     public enum EnemyType
    {
        None,
        Drunk,
        High,
        Zombified
    }
}

