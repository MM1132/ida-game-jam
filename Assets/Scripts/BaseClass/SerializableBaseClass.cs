using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace IdaGameJam.Core
{
    public class SerializabledScriptableObject : ScriptableObject
    {
        [SerializeField,HideInInspector]string _guid;
        public string Guid => _guid;

    #if UNITY_EDITOR
        void OnValidate()
        {
            var path = AssetDatabase.GetAssetPath(this);
            _guid = AssetDatabase.AssetPathToGUID(path);
        }
    #endif
    }
    
}