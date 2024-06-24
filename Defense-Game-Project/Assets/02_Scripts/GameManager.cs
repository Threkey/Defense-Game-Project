using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int wave = 1;

    const float time = 120f;    // 한 웨이브 시간

    public bool isWave { get; set; }
    public bool isMerchant { get; set; }
    public bool isBoss { get; set; }










    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }


}