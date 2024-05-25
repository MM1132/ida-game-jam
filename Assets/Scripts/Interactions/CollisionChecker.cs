using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{ 
    public void OnColliderEnter(bool hit, GameObject obj)
    {
        if(hit)
        {
            Debug.Log(obj.name);
        }else
        {
            Debug.Log("Nothing Hit");
        }
    }
}
