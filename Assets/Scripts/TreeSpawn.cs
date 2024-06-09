using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TreeSpawn : MonoBehaviour
{
    public GameObject tree;
    public float Xmax;
    public float Xmin;
    public float Ymax;
    public float Ymin;
    public float spawnDelay;
    public float spawnTime;
    void Update()
    {
        if(spawnTime < Time.time)
        {
            Spawn();
            spawnTime = spawnDelay + Time.time;
        }
    }
    void Spawn()
    {
        float Xrandom = Random.Range(Xmin, Xmax);
        float Yrandom = Random.Range(Ymin, Ymax);
        Instantiate(tree, transform.position + new Vector3(Xrandom, Yrandom, 0), transform.rotation);
    }
}