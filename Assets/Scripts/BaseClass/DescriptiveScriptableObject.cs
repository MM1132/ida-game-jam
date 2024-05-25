using UnityEngine;

namespace IdaGameJam.Core.SO
{
    /// <summary>
    /// Base Class for all scriptabled object 
    /// </summary>
    public class DescriptionBaseSO :SerializabledScriptableObject
    {
        [TextArea]public string description;
    }
}