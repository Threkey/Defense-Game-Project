using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant : MonoBehaviour
{
    Button[] btnBuy = new Button[3];

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < btnBuy.Length; i++)
        {
            btnBuy[i] = transform.Find("Item" + (i + 1)).Find("Button").GetComponent<Button>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
