using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    GameManager gm;

    const float timeLimit = 120.0f;

    [SerializeField]
    float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        
    }


    void Update()
    {
        // ≈∏¿Ã∏”
        int min = 0;
        int sec = 0;

        if (gm.isWave)
        {
            if (gm.wave == 5)
            {
                gm.isBoss = true;
            }

            Debug.Log("isWave");
            currentTime -= Time.deltaTime;
            if (currentTime <= 0f)
            {
                Debug.Log("currenttime<=0");
                gm.isWave = false;
                gm.wave++;
                gm.isMerchant = true;
                
                currentTime = timeLimit;
            }
            min = (int)(currentTime / 60.0f);
            sec = (int)(currentTime % 60.0f);

            Debug.Log(min);
            Debug.Log(sec);
            transform.Find("TextTimer").GetComponent<TextMeshProUGUI>().text = string.Format("{0:D2} : {1:D2}", min, sec);
        }

    }
}
