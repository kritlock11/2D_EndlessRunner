using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] EnemiesPattern;
    private float timeBtwSpawn;

    public float startTimeBtwSpawn;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //Debug.Log($"timeBtwSpawn = {timeBtwSpawn}");
        if (timeBtwSpawn<=0)
        {
            int rand = Random.Range(0, EnemiesPattern.Length);
            Instantiate(EnemiesPattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else 
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }








}
