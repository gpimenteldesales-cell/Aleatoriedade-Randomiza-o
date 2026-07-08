using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] spawnItem;
    public GameObject enemyPrefab;
    public GameObject itemPrefab;
    public int randomSpawn;
    void Start()
    {
        randomSpawn = Random.Range(0,4);
        Instantiate(enemyPrefab, spawnPoints[randomSpawn]);
        Instantiate (itemPrefab[randomSpawn], spawnItem[randomSpawn]);
    }

    void Update()
    {
        
    }
}