using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    public GameObject[] Blocks = new GameObject[2];
    private int rand;
    void Start()
    {
        rand = Random.Range(0, 2);
        Instantiate(Blocks[rand], transform.position, Quaternion.identity);
    }
}
