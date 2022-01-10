using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefabs;
    private float spawnX = 38;
    private float spawnY = 3;
    private float startdelay = 1.5f;
    private float spawnInterval = 2.5f;
    private GameManager gameManager;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor", startdelay , spawnInterval);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Meteor spawn
    void SpawnMeteor()
    {
        gameManager.StartGame();
        int meteorIndex = Random.Range(0, meteorPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), spawnY, 0);
        Instantiate(meteorPrefabs[meteorIndex], spawnPos, meteorPrefabs[meteorIndex].transform.rotation);       
    }
}
