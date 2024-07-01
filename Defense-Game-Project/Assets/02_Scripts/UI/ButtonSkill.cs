using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSkill : MonoBehaviour
{
    GameManager gm;

    Button btnSkill1, btnSkill2;
    public GameObject skill1, skill2;
    Image imageSkill1, imageSkill2;

    const float skillCooldown = 10.0f;
    float currentSkill1Colldown = 10.0f;
    float currentSkill2Colldown = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        btnSkill1 = transform.Find("ButtonSkill1").GetComponent<Button>();
        btnSkill2 = transform.Find("ButtonSkill2").GetComponent<Button>();

        imageSkill1 = btnSkill1.gameObject.transform.Find("ImageSkill1").GetComponent<Image>();
        imageSkill2 = btnSkill2.gameObject.transform.Find("ImageSkill2").GetComponent<Image>();

        btnSkill1.onClick.AddListener(Skill1);
        btnSkill2.onClick.AddListener(Skill2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Skill1()
    {
        Instantiate(skill1);
        currentSkill1Colldown = 0.0f;
        imageSkill1.fillAmount = 0.0f;
        btnSkill1.interactable = false;
        StartCoroutine(coSkill1Colldown());
    }

    void Skill2()
    {
        Instantiate(skill2);
        currentSkill2Colldown = 0.0f;
        imageSkill2.fillAmount = 0.0f;
        btnSkill2.interactable = false;
        StartCoroutine(coSkill2Colldown());
    }

    IEnumerator coSkill1Colldown()
    {
        while(currentSkill1Colldown < skillCooldown - skillCooldown * gm.SkillColldownReduction)
        {
            currentSkill1Colldown += 0.01f;

            imageSkill1.fillAmount = currentSkill1Colldown / (skillCooldown - (skillCooldown * gm.SkillColldownReduction));

            yield return new WaitForSeconds(0.01f);
        }

        btnSkill1.interactable = true;
        yield return null;
        
    }

    IEnumerator coSkill2Colldown()
    {
        while (currentSkill2Colldown < skillCooldown - skillCooldown * gm.SkillColldownReduction)
        {
            currentSkill2Colldown += 0.01f;

            imageSkill2.fillAmount = currentSkill2Colldown / (skillCooldown - (skillCooldown * gm.SkillColldownReduction));

            yield return new WaitForSeconds(0.01f);
        }

        btnSkill2.interactable = true;
        yield return null;
    }
}