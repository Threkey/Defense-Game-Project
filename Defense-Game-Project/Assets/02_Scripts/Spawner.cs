using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameManager gm;

    public GameObject monsterRat;
    public GameObject monsterBat;
    public GameObject monsterBoss;

    private Vector3 spawnPos;

    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        spawnPos = transform.position;

        StartCoroutine("coSpawnMonster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator coSpawnMonster()
    {
        while (gm.isWave)
        {
            if (gm.isBoss)
                Instantiate(monsterBoss, spawnPos, Quaternion.identity);
            else
            {
                Instantiate(monsterRat, spawnPos, Quaternion.identity);
                Instantiate(monsterRat, spawnPos, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}