using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPause : MonoBehaviour
{
    public GameObject option;
    Button btnPause;
    // Start is called before the first frame update
    void Start()
    {
        btnPause = GetComponent<Button>();

        btnPause.onClick.AddListener(Pause);
    }

    void Pause()
    {
        option.SetActive(true);
        Time.timeScale = 0.0f;
    }
}