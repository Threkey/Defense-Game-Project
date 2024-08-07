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


    // �÷��̾� �ɷ�ġ
    private float attackSpeed = 1.0f;

    private int attackDamage = 2;

    private float attackRange = 12.0f;

    private float hp;

    public const float maxHp = 100f;

    private float skillCooldownReduction = 0.0f;


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

    public float Hp
    {
        get { return hp; }
    }

    public float SkillColldownReduction
    {
        get { return skillCooldownReduction; }
    }

    // �̱���
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