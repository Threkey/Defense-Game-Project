using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    Button btnQuitGame;
    Button btnCancel;
    Slider sliderBgm;
    Slider sliderSfx;

    // Start is called before the first frame update
    void Start()
    {
        // ������Ʈ �Ҵ�
        btnQuitGame = transform.Find("ImageOption").Find("ButtonQuitGame").GetComponent<Button>();
        btnCancel = transform.Find("ImageOption").Find("ButtonCancel").GetComponent<Button>();
        sliderBgm = transform.Find("ImageOption").Find("SliderBgm").GetComponent<Slider>();
        sliderSfx = transform.Find("ImageOption").Find("SliderSfx").GetComponent<Slider>();

        // ��ư �̺�Ʈ
        btnQuitGame.onClick.AddListener(QuitGame);
        btnCancel.onClick.AddListener(Cancel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void Cancel()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
