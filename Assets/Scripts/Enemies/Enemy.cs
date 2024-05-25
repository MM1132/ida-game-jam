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
    }
}