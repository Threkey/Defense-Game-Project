using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class MonsterRat : MonoBehaviour
{
    GameManager gm;

    Slider sliderHp;
    float hp;
    float maxHp;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        sliderHp = transform.Find("SliderRatHp").GetComponent<Slider>();

        maxHp = gm.wave * 10f;
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        sliderHp.value = hp / maxHp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TilemapObject")
            Destroy(gameObject);
    }
}
