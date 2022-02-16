using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    public GameObject enemyPrefabs;
    private float SpawnRange = 9f;
     // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");

        float SpawnPosX = Random.Range(-SpawnRange, SpawnRange);
        float SpawnPosZ = Random.Range(-SpawnRange, SpawnRange);
        Vector3 RandomPos =new Vector3(SpawnPosX, 0, SpawnPosZ);
       Instantiate(enemyPrefabs, new Vector3(0, 0, 6), enemyPrefabs.transform.rotation);
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 lookDirection= (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection* speed);
       
    }
}
