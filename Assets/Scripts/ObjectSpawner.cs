using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]Transform[] spawnPoints;
    [SerializeField]Vector3 rectPost;
    [SerializeField]float xSpawnPoint;
    [SerializeField]GameObject dummyObject;

    void Start ()
    {
        spawnPoints = GetComponentsInChildren<RectTransform>();

        //generate random spawnpoint
        xSpawnPoint = Random.Range(0,Screen.width);
        SpawnChildrenObject();
    }

    void SpawnChildrenObject()
    {
        //
        var x = new GameObject("Spawned");
        x.AddComponent<RectTransform>();
        x.transform.localPosition = rectPost;
        Instantiate(x,this.transform);
    }
}
