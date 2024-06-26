using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2Cat : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }
}
