using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public GameObject[] Blocks = new GameObject[2];
    private int rand;
    void Start()
    {
        rand = Random.Range(0, 2);
        var Block = Blocks[rand];
        Instantiate(Block, transform.position, Quaternion.identity);
    }
}
