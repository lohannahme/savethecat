using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public int NumOfCircles = 1;
    public int waveModifier = 0;
    public float RadiusSize = 15f;

    public GameObject prefab;
    public Transform spawnerPos;

    List<GameObject> spawnedGo = new List<GameObject>();
    int NumOfCirclesLast = 0;

    private void Awake()
    {
        NumOfCirclesLast = NumOfCircles;
    }

    private void Start()
    {
        SpawnNew();
    }

    private void Update()
    {
        
        if (GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            if (waveModifier != 256)
            {
            waveModifier = waveModifier*2;
            }
            SpawnNew();
            Debug.Log(waveModifier);
        }
    }

    void SpawnNew()
    {
        foreach (var item in spawnedGo)
        {
            Destroy(item);
        }

        Vector2 center = spawnerPos.position;

        for (int i = 1; i <= NumOfCircles; i++)
        {
            for (int j = 0; j < waveModifier ; j++)
            {
                
                int a = 360 / waveModifier * j;
                Vector3 pos = RandomCircle(center, RadiusSize * i, a);
                GameObject newGo = Instantiate(prefab, pos, Quaternion.identity);

                spawnedGo.Add(newGo);
            }
            NumOfCirclesLast = NumOfCircles;
        }
    }

    Vector3 RandomCircle(Vector3 center, float radius, int a)
    {
        float ang = a;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
