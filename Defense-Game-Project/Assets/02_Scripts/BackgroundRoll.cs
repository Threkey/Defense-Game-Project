using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRoll : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    float width;
    // Start is called before the first frame update
    void Start()
    {
        width = GetComponent<Collider2D>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= -width)
        {
            transform.position = Vector3.right * width;
        }
    }
}
