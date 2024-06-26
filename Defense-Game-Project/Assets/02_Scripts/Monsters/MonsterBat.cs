using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterBat : MonoBehaviour
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

        sliderHp = transform.Find("Canvas").Find("SliderBatHp").GetComponent<Slider>();

        maxHp = gm.wave * 7f;
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
        if (collision.gameObject.name == "TilemapObject" || collision.gameObject.name.Contains("Skill"))
            StartCoroutine(coDestroy());
    }

    IEnumerator coDestroy()
    {
        speed = 0f;
        sliderHp.gameObject.SetActive(false);
        Animator anim = GetComponent<Animator>();
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}

