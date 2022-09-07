using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] SpawnPosition;
    public GameObject[] Monster;
    int MaxMonster;
    int MaxSpawnPosition;

    bool isGameOver = false;

    private void Start()
    {
        // Get length
        MaxSpawnPosition = SpawnPosition.Length;
        MaxMonster = Monster.Length;

        // Coroutine Start
        StartCoroutine(SpawnEnemy());
    }

    // Coroutine function stopping spawn enemy for a minutes
    IEnumerator SpawnEnemy()
    {
        while (!isGameOver)
        {
            int randomPos = Random.Range(0, MaxSpawnPosition);
            Instantiate(Monster[Random.Range(0, MaxMonster)], SpawnPosition[randomPos].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

}
