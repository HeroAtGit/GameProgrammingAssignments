using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3 (Random.Range(-4,4), 1f, Random.Range(-4,4));

        Instantiate(Enemy, spawnPosition, Quaternion.identity);
    }
}
