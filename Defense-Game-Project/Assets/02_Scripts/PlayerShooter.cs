using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    GameManager gm;

    public GameObject bullet;

    GameObject target;

    Vector2 bulletDir;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;

        StartCoroutine(coShoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator coShoot()
    {
        while(true)
        {
            RaycastHit2D[] hit = Physics2D.BoxCastAll(transform.position, new Vector2(12, 7), 0, Vector2.right);

            // 감지된 오브젝트 적 중에 가장 거리가 가까운 것 인식
            if (hit.Length > 0)
            {
                float minDis = gm.AttackRange;

                for (int i = 0; i < hit.Length; i++)
                {
                    if (hit[i].collider.tag == "Enemy" && Vector2.Distance(hit[i].transform.position, transform.position) < minDis)
                    {
                        target = hit[i].transform.gameObject;
                        bulletDir = target.transform.position - transform.position;
                        float bulletAngle = Vector2.Angle(bulletDir, Vector2.right) * Mathf.Rad2Deg;
                        Instantiate(bullet, transform.position, Quaternion.Euler(Vector3.forward * bulletAngle));
                        yield return new WaitForSeconds(1f / gm.AttackSpeed);
                    }
                    else
                    {
                        target = null;
                        yield return null;
                    }

                }

            }

            else
                yield return null;
        }
    }
}