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

    private float spawnInterval = 3.0f;
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
        while (true)
        {
            //if(gm.isWave)
            if(true)
            {
                //if (gm.isBoss)
                if(false)
                    Instantiate(monsterBoss, spawnPos, Quaternion.identity);
                else
                {
                    Instantiate(monsterRat, spawnPos, monsterRat.transform.rotation);
                    //Instantiate(monsterBat, spawnPos, monsterBat.transform.rotation);
                }
                yield return new WaitForSeconds(spawnInterval);
            }
            else
                yield return null;

        }
    }
}