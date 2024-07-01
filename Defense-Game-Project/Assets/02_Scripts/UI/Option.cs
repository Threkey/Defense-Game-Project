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
        try
        {
            btnQuitGame = transform.Find("ImageOption").Find("ButtonQuitGame").GetComponent<Button>();
        }
        catch (System.NullReferenceException e)
        {
            Debug.Log(e.Message);
        }

        btnCancel = transform.Find("ImageOption").Find("ButtonCancel").GetComponent<Button>();
        sliderBgm = transform.Find("ImageOption").Find("SliderBgm").GetComponent<Slider>();
        sliderSfx = transform.Find("ImageOption").Find("SliderSfx").GetComponent<Slider>();

        // ��ư �̺�Ʈ
        if(btnQuitGame != null)
            btnQuitGame.onClick.AddListener(QuitGame);
        btnCancel.onClick.AddListener(Cancel);
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
