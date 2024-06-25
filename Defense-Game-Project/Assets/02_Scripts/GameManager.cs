using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int wave = 1;

    public bool isWave { get; set; }
    public bool isMerchant { get; set; }
    public bool isBoss { get; set; }


    public int money { get; set; }


    // ÇÃ·¹ÀÌ¾î ´É·ÂÄ¡
    private float attackSpeed = 1.0f;

    private int attackDamage = 2;

    private float attackRange = 12.0f;

    private int hp;

    public const int maxHp = 100;


    public float AttackSpeed
    {
        get { return attackSpeed; }
    }

    public int AttackDamage
    {
        get { return attackDamage; }
    }

    public float AttackRange
    {
        get { return attackRange; }
    }

    public int Hp
    {
        get { return hp; }
    }

    // ½Ì±ÛÅæ
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        hp = maxHp;
    }


}