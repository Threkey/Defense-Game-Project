using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroy());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }

}
