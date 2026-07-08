using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] spawnItem;
    public GameObject playerPrefab;
    public GameObject[] itemPrefab;
    public int random;
    public int randomItem;
    void Start()
    {
        random = Random.Range(0,4);
        Instantiate(playerPrefab, spawnPoints[random]);
        randomItem = Random.Range(0,3);
        Instantiate (itemPrefab[random], spawnItem[random]);
    }

    void Update()
    {
        
    }
}