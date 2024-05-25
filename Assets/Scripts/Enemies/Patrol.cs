using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdaGameJam.Core
{
    public class Patrol : MonoBehaviour
    {
        //gets the length of the platform and divides by 2
        float pointA,pointB;
        [SerializeField]RectTransform _rect => GetComponent<RectTransform>();
        [SerializeField]float frame;
        float movementTime;
        float xMin,xMax;
        bool landed = false;

        public void OnLanded(bool hit, GameObject obj)
        {
            if (hit)
            {
                landed = true;
                if(obj.TryGetComponent(out RectTransform x))
                {
                    Debug.Log($"Fired : {obj.gameObject.name}");
                    //half of the width
                    pointA = -x.sizeDelta.x/20;
                    pointB = x.sizeDelta.x/20;

                    xMin = pointA;
                    xMax = pointB;
                };
            }
        }

        void Update()
        {
            if(!landed)return;
            ScoutAround();
        }

        void ScoutAround()
        {
            movementTime += Time.deltaTime/frame;

            if(movementTime >1f)
            {
                var _ = xMin;
                xMin = xMax;
                xMax = _;
                
                //reset the time 
                movementTime = 0f;
            }
            var t = Mathf.Lerp(xMin,xMax,movementTime);
            _rect.transform.localPosition = new Vector3(t,_rect.transform.localPosition.y,_rect.transform.localPosition.z);
        }
    }
}