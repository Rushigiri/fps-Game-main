using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawnRX;
    public float SpawnPZ;
    int i = 0;
    float LifeTime;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnEnable()
    {
        LifeTime = 5f;
    }
    // Update is called once per frame
    void Update()
    {
        LifeTime -= Time.deltaTime;
        if (LifeTime <= 0.1f)
        {
            if (i < 50)
            {
                Vector3 spawnPos = new Vector3(Random.Range(-SpawnRX, SpawnRX), 0, SpawnPZ);
                Instantiate( EnemyPrefab , spawnPos, EnemyPrefab.transform.rotation);
                i++;
            }
        }


    }
}
