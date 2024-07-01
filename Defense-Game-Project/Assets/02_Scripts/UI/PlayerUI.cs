using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    GameManager gm;

    Slider sliderPlayerHp;
    TextMeshProUGUI textMoney;
    TextMeshProUGUI textPlayerName;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        sliderPlayerHp = transform.Find("PlayerHp").GetComponent<Slider>();
        textMoney = transform.Find("ImageMoneyBackground").Find("TextMoney").GetComponent<TextMeshProUGUI>();
        textPlayerName = transform.Find("ImagePlayerNameBackground").Find("TextPlayerName").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerHp();
        UpdateMoney();
    }

    void UpdatePlayerHp()
    {
        sliderPlayerHp.value = gm.Hp / GameManager.maxHp;
    }

    void UpdateMoney()
    {
        textMoney.text = gm.money.ToString();
    }
}